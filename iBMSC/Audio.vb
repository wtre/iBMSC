﻿Imports CSCore
Imports CSCore.Codecs
Imports CSCore.SoundOut
Imports NVorbis

Module Audio
    Dim Output As WasapiOut
    Dim Source As IWaveSource
    Dim SupportedExt() As String = CodecFactory.Instance.GetSupportedFileExtensions()

    Public Sub Initialize()
        Output = New WasapiOut()
        CodecFactory.Instance.Register("ogg", New CodecFactoryEntry(Function(s)
                                                                        Return New NVorbisSource(s).ToWaveSource()
                                                                    End Function, ".ogg"))
        SupportedExt = CodecFactory.Instance.GetSupportedFileExtensions()
    End Sub

    Public Sub Finalize()
        Output.Stop()
        Output.Dispose()
        Output = Nothing
    End Sub

    Public Function CheckFilename(ByVal filename As String) As String
        If File.Exists(filename) Then
            Return filename
        End If

        For Each ext In SupportedExt
            If File.Exists(Path.ChangeExtension(filename, "." & ext)) Then Return Path.ChangeExtension(filename, "." & ext)
        Next
        Return filename
    End Function

    Public Function GetSupportedExtensions(Optional appendStr As String = ".") As String()
        Dim Ext(UBound(SupportedExt)) As String
        For i = 0 To UBound(SupportedExt)
            Ext(i) = appendStr & SupportedExt(i)
        Next
        Return Ext
    End Function

    Public Sub Play(ByVal filename As String)
        If Source IsNot Nothing Then
            Output.Stop()
            Source.Dispose()
            Source = Nothing
        End If

        If filename Is "" Then
            Return
        End If

        Dim fn = CheckFilename(filename)

        ' P: How to catch without crashing
        Try
            Source = CodecFactory.Instance.GetCodec(fn)
            Output.Initialize(Source)
            Output.Play()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub StopPlaying()
        Output.Stop()
    End Sub
End Module

' P: Probably not the best way to duplicate it into a class
Public Class AudioC
    Dim Output As WasapiOut
    Dim Source As IWaveSource
    Dim SupportedExt() As String = CodecFactory.Instance.GetSupportedFileExtensions()

    Public Sub Initialize()
        Output = New WasapiOut()
        CodecFactory.Instance.Register("ogg", New CodecFactoryEntry(Function(s)
                                                                        Return New NVorbisSource(s).ToWaveSource()
                                                                    End Function, ".ogg"))
        SupportedExt = CodecFactory.Instance.GetSupportedFileExtensions()
    End Sub

    Public Sub Finalized()
        Output.Stop()
        Output.Dispose()
        Output = Nothing
    End Sub

    Public Function CheckFilename(ByVal filename As String) As String
        If File.Exists(filename) Then
            Return filename
        End If

        For Each ext In SupportedExt
            If File.Exists(Path.ChangeExtension(filename, "." & ext)) Then Return Path.ChangeExtension(filename, "." & ext)
        Next
        Return filename
    End Function

    Public Function GetSupportedExtensions(Optional appendStr As String = ".") As String()
        Dim Ext(UBound(SupportedExt)) As String
        For i = 0 To UBound(SupportedExt)
            Ext(i) = appendStr & SupportedExt(i)
        Next
        Return Ext
    End Function

    Public Sub Play(ByVal filename As String)
        If Source IsNot Nothing Then
            Output.Stop()
            Source.Dispose()
            Source = Nothing
        End If

        If filename Is "" Then
            Return
        End If

        Dim fn = CheckFilename(filename)

        ' P: How to catch without crashing
        Try
            Source = CodecFactory.Instance.GetCodec(fn)
            Output.Initialize(Source)
            Output.Play()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub StopPlaying()
        Output.Stop()
    End Sub
End Class

Class NVorbisSource
    Implements CSCore.ISampleSource
    Dim _stream As Stream
    Dim _vorbisReader As VorbisReader
    Dim _waveFormat As WaveFormat
    Dim _disposed As Boolean

    Public Sub New(stream As Stream)
        If stream Is Nothing Or Not stream.CanRead Then
            Throw New ArgumentException("stream")
        End If
        _stream = stream
        _vorbisReader = New VorbisReader(stream, Nothing)
        _waveFormat = New WaveFormat(_vorbisReader.SampleRate, 32, _vorbisReader.Channels, AudioEncoding.IeeeFloat)
    End Sub

    Public ReadOnly Property CanSeek As Boolean Implements IAudioSource.CanSeek
        Get
            Return _stream.CanSeek
        End Get
    End Property

    Public ReadOnly Property WaveFormat As WaveFormat Implements IAudioSource.WaveFormat
        Get
            Return _waveFormat
        End Get
    End Property

    Public ReadOnly Property Length As Long Implements IAudioSource.Length
        Get
            Return CInt(IIf(CanSeek, _vorbisReader.TotalTime.TotalSeconds * _waveFormat.SampleRate * _waveFormat.Channels, 0))
        End Get
    End Property

    Public Property Position As Long Implements IAudioSource.Position
        Get
            Return CInt(IIf(CanSeek, _vorbisReader.TimePosition.TotalSeconds * _vorbisReader.SampleRate * _vorbisReader.Channels, 0))
        End Get
        Set(value As Long)
            If Not CanSeek Then
                Throw New InvalidOperationException("Can't seek this stream.")
            End If
            If value < 0 Or value >= Length Then
                Throw New ArgumentOutOfRangeException("value")
            End If
            _vorbisReader.TimePosition = TimeSpan.FromSeconds(value / _vorbisReader.SampleRate / _vorbisReader.Channels)
        End Set
    End Property


    Public Function Read(buffer As Single(), offset As Integer, count As Integer) As Integer Implements ISampleSource.Read
        Return _vorbisReader.ReadSamples(buffer, offset, count)
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        If Not _disposed Then
            '_vorbisReader.Dispose()
        Else
            'Throw New ObjectDisposedException("NVorbisSource")
        End If
        _disposed = True
    End Sub

End Class
