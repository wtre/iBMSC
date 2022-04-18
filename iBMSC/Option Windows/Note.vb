Namespace Editor
    Public Structure Note
        Public VPosition As Double
        Public ColumnIndex As Integer
        Public Value As Long 'x10000
        Public LongNote As Boolean
        Public Hidden As Boolean
        Public Length As Double
        Public Landmine As Boolean
        Public Ghost As Boolean
        Public Comment As Boolean

        Public LNPair As Integer
        Public Selected As Boolean
        Public HasError As Boolean
        Public ErrorType As Integer

        'Public TempBoolean As Boolean
        Public TempSelected As Boolean
        Public TempMouseDown As Boolean
        Public TempIndex As Integer

        Public Function equalsBMSE(note As Note) As Boolean
            Return VPosition = note.VPosition And
               ColumnIndex = note.ColumnIndex And
               Value = note.Value And
               LongNote = note.LongNote And
               Hidden = note.Hidden And
               Landmine = note.Landmine And
               Ghost = note.Ghost And
               Comment = note.Comment
        End Function
        Public Function equalsNT(note As Note) As Boolean
            Return VPosition = note.VPosition And
               ColumnIndex = note.ColumnIndex And
               Value = note.Value And
               Hidden = note.Hidden And
               Length = note.Length And
               Landmine = note.Landmine And
               Ghost = note.Ghost And
               Comment = note.Comment
        End Function

        Public Sub New(nColumnIndex As Integer,
                       nVposition As Double,
                       nValue As Long,
                       Optional nLongNote As Double = 0,
                       Optional nHidden As Boolean = False,
                       Optional nSelected As Boolean = False,
                       Optional nLandmine As Boolean = False,
                       Optional nGhost As Boolean = False,
                       Optional nComment As Boolean = False)
            VPosition = nVposition
            ColumnIndex = nColumnIndex
            Value = nValue
            LongNote = CBool(IIf(nLongNote > 0, True, False))
            Length = nLongNote
            Hidden = nHidden
            Landmine = nLandmine
            Ghost = nGhost
            Comment = nComment
        End Sub

        Public Sub New(nColumnIndex As Integer,
                       nVposition As Double,
                       nValue As Long,
                       Optional nLongNote As Boolean = False,
                       Optional nHidden As Boolean = False,
                       Optional nSelected As Boolean = False,
                       Optional nLandmine As Boolean = False,
                       Optional nGhost As Boolean = False,
                       Optional nComment As Boolean = False)
            VPosition = nVposition
            ColumnIndex = nColumnIndex
            Value = nValue
            LongNote = nLongNote
            Length = 0
            Hidden = nHidden
            Landmine = nLandmine
            Ghost = nGhost
            Comment = nComment
        End Sub

        Friend Function ToBytes() As Byte()
            Dim MS As New MemoryStream()
            Dim bw As New BinaryWriter(MS)
            WriteBinWriter(bw)

            Return MS.GetBuffer()
        End Function

        Friend Sub WriteBinWriter(ByRef bw As BinaryWriter)
            bw.Write(VPosition)
            bw.Write(ColumnIndex)
            bw.Write(Value)
            bw.Write(LongNote)
            bw.Write(Length)
            bw.Write(Hidden)
            bw.Write(Landmine)
            bw.Write(Ghost)
            bw.Write(Comment)
        End Sub

        Friend Sub FromBinReader(ByRef br As BinaryReader)
            VPosition = br.ReadDouble()
            ColumnIndex = br.ReadInt32()
            Value = br.ReadInt64()
            LongNote = br.ReadBoolean()
            Length = br.ReadDouble()
            Hidden = br.ReadBoolean()
            Landmine = br.ReadBoolean()
            Ghost = br.ReadBoolean()
            Comment = br.ReadBoolean()
        End Sub

        Friend Sub FromBytes(ByRef bytes() As Byte)
            Dim br As New BinaryReader(New MemoryStream(bytes))
            FromBinReader(br)
        End Sub
    End Structure
End Namespace
