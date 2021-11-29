/*if (i + 2 > strToWrite.Count)
	break;
else
{
	EscapeSequence escSeq = new EscapeSequence();
	string strEscSeqLen = String.Concat(strToWrite[i + 1], strToWrite[i + 2]);
	escSeq.length = Byte.Parse(strEscSeqLen, NumberStyles.HexNumber);
	escSeq.unk1 = Byte.Parse(String.Concat(strToWrite[i + 3], strToWrite[i + 4]), NumberStyles.HexNumber);

	switch (escSeq.length)
	{
		case 0x06:
			escSeq.binValue1 = UInt16.Parse(String.Concat(strToWrite[i + 5], strToWrite[i + 6], strToWrite[i + 7], strToWrite[i + 8]), NumberStyles.HexNumber);
			break;

		case 0x08:
			escSeq.binValue1 = UInt16.Parse(String.Concat(strToWrite[i + 5], strToWrite[i + 6], strToWrite[i + 7], strToWrite[i + 8]), NumberStyles.HexNumber);
			escSeq.binValue2 = UInt16.Parse(String.Concat(strToWrite[i + 9], strToWrite[i + 10], strToWrite[i + 11], strToWrite[i + 12]), NumberStyles.HexNumber);

			break;

		case 0x0E:
			escSeq.binValue1 = UInt16.Parse(String.Concat(strToWrite[i + 5], strToWrite[i + 6], strToWrite[i + 7], strToWrite[i + 8]), NumberStyles.HexNumber);
			escSeq.binValue2 = UInt16.Parse(String.Concat(strToWrite[i + 9], strToWrite[i + 10], strToWrite[i + 11], strToWrite[i + 12]), NumberStyles.HexNumber);
			escSeq.binValue3 = UInt16.Parse(String.Concat(strToWrite[i + 13], strToWrite[i + 14], strToWrite[i + 15], strToWrite[i + 16]), NumberStyles.HexNumber);
			escSeq.binValue4 = UInt16.Parse(String.Concat(strToWrite[i + 17], strToWrite[i + 18], strToWrite[i + 19], strToWrite[i + 20]), NumberStyles.HexNumber);
			escSeq.binValue5 = UInt16.Parse(String.Concat(strToWrite[i + 21], strToWrite[i + 22], strToWrite[i + 23], strToWrite[i + 24]), NumberStyles.HexNumber);
			break;

		case 0x36:
			for (int j = 0; j < escSeq.length)
			{
				escSeq.bigBinValue += Byte.Parse(strToWrite)
			}
			break;

		default:
			System.Windows.Forms.MessageBox.Show($"Error, please report this issue to Bussun#0586 on Discord. What went wrong: Unknown escape sequence\nMessage name: {entry.entryName} {entry.entryNo}");
			break;
	}

	List<Byte> escSeqToWrite = BytesFromEscapeSequence(escSeq);
	foreach (Byte b in escSeqToWrite)
	{
		m_File.Writer.Write(b);
	}
	i += escSeq.length * 2 - 3;
}*/