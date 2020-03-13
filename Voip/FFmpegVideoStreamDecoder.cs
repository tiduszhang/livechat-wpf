﻿using FFmpeg.AutoGen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace Voip
{
    public sealed unsafe class VideoStreamDecoder : IDisposable
    {
        private readonly AVCodecContext* _pCodecContext;
        //private readonly AVFormatContext* _pFormatContext;
        //private readonly int _streamIndex;
        private readonly AVFrame* _pFrame;
        private readonly AVFrame* _receivedFrame;
        private readonly AVPacket* _pPacket;

        public unsafe VideoStreamDecoder(AVHWDeviceType HWDeviceType = AVHWDeviceType.AV_HWDEVICE_TYPE_NONE)
        {
            _pCodecContext = ffmpeg.avcodec_alloc_context3(null);
            AVCodec* codec = ffmpeg.avcodec_find_decoder(AVCodecID.AV_CODEC_ID_H264);

            if (HWDeviceType != AVHWDeviceType.AV_HWDEVICE_TYPE_NONE)
            {
                ffmpeg.av_hwdevice_ctx_create(&_pCodecContext->hw_device_ctx, HWDeviceType, null, null, 0).ThrowExceptionIfError();
            }

            if (ffmpeg.avcodec_open2(_pCodecContext, codec, null) >= 0)
                _receivedFrame = ffmpeg.av_frame_alloc();

            CodecName = ffmpeg.avcodec_get_name(codec->id);
            FrameSize = new Size(_pCodecContext->width, _pCodecContext->height);
            //PixelFormat = _pCodecContext->pix_fmt;

            _pPacket = ffmpeg.av_packet_alloc();
            _pFrame = ffmpeg.av_frame_alloc();
        }

        public string CodecName { get; }
        public Size FrameSize { get; set; }
        public AVPixelFormat PixelFormat
        {
            get
            {
                return AVPixelFormat.AV_PIX_FMT_YUV420P;
            }
        }

        public void Dispose()
        {
            ffmpeg.av_frame_unref(_pFrame);
            ffmpeg.av_free(_pFrame);

            ffmpeg.av_packet_unref(_pPacket);
            ffmpeg.av_free(_pPacket);

            ffmpeg.avcodec_close(_pCodecContext);
            //var pFormatContext = _pFormatContext;
            //ffmpeg.avformat_close_input(&pFormatContext);
        }


        public unsafe Int32 PutVideoStream(byte[] buffer)
        {
            AVPacket packet = new AVPacket();
            fixed (byte* pBuffer = buffer)
            {
                packet.data = pBuffer;    //这里填入一个指向完整H264数据帧的指针 
            }
            packet.size = buffer.Length;        //这个填入H264数据帧的大小  
            int ret = ffmpeg.avcodec_send_packet(_pCodecContext, &packet);
            return ret;
        }
        public bool TryDecodeNextFrame(out AVFrame frame)
        {
            ffmpeg.av_frame_unref(_pFrame);
            ffmpeg.av_frame_unref(_receivedFrame);
            int error;
            do
            {
                //try
                //{
                //    do
                //    {
                //        error = ffmpeg.av_read_frame(_pFormatContext, _pPacket);
                //        if (error == ffmpeg.AVERROR_EOF)
                //        {
                //            frame = *_pFrame;
                //            return false;
                //        }

                //        error.ThrowExceptionIfError();
                //    } while (_pPacket->stream_index != _streamIndex);

                //    ffmpeg.avcodec_send_packet(_pCodecContext, _pPacket).ThrowExceptionIfError();
                //}
                //finally
                //{
                //    ffmpeg.av_packet_unref(_pPacket);
                //}

                error = ffmpeg.avcodec_receive_frame(_pCodecContext, _pFrame);
            } while (error == ffmpeg.AVERROR(ffmpeg.EAGAIN));
            error.ThrowExceptionIfError();
            if (_pCodecContext->hw_device_ctx != null)
            {
                if (FrameSize.Width == 0 && _pCodecContext->width != 0)
                {
                    FrameSize = new Size(_pCodecContext->width, _pCodecContext->height);
                }
                ffmpeg.av_hwframe_transfer_data(_receivedFrame, _pFrame, 0).ThrowExceptionIfError();
                frame = *_receivedFrame;
            }
            else
            {
                frame = *_pFrame;
            }
            return true;
        }

        //public IReadOnlyDictionary<string, string> GetContextInfo()
        //{
        //    AVDictionaryEntry* tag = null;
        //    var result = new Dictionary<string, string>();
        //    while ((tag = ffmpeg.av_dict_get(_pFormatContext->metadata, "", tag, ffmpeg.AV_DICT_IGNORE_SUFFIX)) != null)
        //    {
        //        var key = Marshal.PtrToStringAnsi((IntPtr)tag->key);
        //        var value = Marshal.PtrToStringAnsi((IntPtr)tag->value);
        //        result.Add(key, value);
        //    }

        //    return result;
        //}
    }
}