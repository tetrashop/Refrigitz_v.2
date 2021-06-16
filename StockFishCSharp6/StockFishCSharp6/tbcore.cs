using System;

public static class GlobalMembersTbcore
{
	/*
	  Copyright (c) 2011-2013 Ronald de Man
	  This file may be redistributed and/or modified without restrictions.
	
	  tbcore.c contains engine-independent routines of the tablebase probing code.
	  This file should not need to much adaptation to add tablebase probing to
	  a particular engine, provided the engine is written in C or C++.
	*/

	#if ! _WIN32
	#endif

	#define TBMAX_PIECE
	#define TBMAX_PAWN
	#define HSHMAX

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define Swap(a,b) {int tmp=a;a=b;b=tmp;}
	#define Swap

	#define TB_PAWN
	#define TB_KNIGHT
	#define TB_BISHOP
	#define TB_ROOK
	#define TB_QUEEN
	#define TB_KING

	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define TB_WPAWN TB_PAWN
	#define TB_WPAWN
	//C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
	//ORIGINAL LINE: #define TB_BPAWN (TB_PAWN | 8)
	#define TB_BPAWN

	internal static LOCK_T TB_mutex = new LOCK_T();

	internal static bool initialized = false;
	internal static int num_paths = 0;
	internal static string path_string = null;
	internal static string[] paths = null;

	internal static int TBnum_piece;
	internal static int TBnum_pawn;
	internal static TBEntry_piece[] TB_piece = Arrays.InitializeWithDefaultInstances<TBEntry_piece>(DefineConstants.TBMAX_PIECE);
	internal static TBEntry_pawn[] TB_pawn = Arrays.InitializeWithDefaultInstances<TBEntry_pawn>(DefineConstants.TBMAX_PAWN);

	internal static TBHashEntry[,] TB_hash = new TBHashEntry[1 << DefineConstants.TBHASHBITS, DefineConstants.HSHMAX];

	#define DTZ_ENTRIES

	internal static DTZTableEntry[] DTZ_table = Arrays.InitializeWithDefaultInstances<DTZTableEntry>(DefineConstants.DTZ_ENTRIES);

	internal static void init_indices()
	{
	  int i;
	  int j;
	  int k;

	// binomial[k-1][n] = Bin(n, k)
	  for (i = 0; i < 5; i++)
	  {
		for (j = 0; j < 64; j++)
		{
		  int f = j;
		  int l = 1;
		  for (k = 1; k <= i; k++)
		  {
			f *= (j - k);
			l *= (k + 1);
		  }
		  binomial[i, j] = f / l;
		}
	  }

	  for (i = 0; i < 5; i++)
	  {
		int s = 0;
		for (j = 0; j < 6; j++)
		{
		  pawnidx[i, j] = s;
		  s += (i == 0) ? 1 : binomial[i - 1, ptwist[invflap[j]]];
		}
		pfactor[i, 0] = s;
		s = 0;
		for (; j < 12; j++)
		{
		  pawnidx[i, j] = s;
		  s += (i == 0) ? 1 : binomial[i - 1, ptwist[invflap[j]]];
		}
		pfactor[i, 1] = s;
		s = 0;
		for (; j < 18; j++)
		{
		  pawnidx[i, j] = s;
		  s += (i == 0) ? 1 : binomial[i - 1, ptwist[invflap[j]]];
		}
		pfactor[i, 2] = s;
		s = 0;
		for (; j < 24; j++)
		{
		  pawnidx[i, j] = s;
		  s += (i == 0) ? 1 : binomial[i - 1, ptwist[invflap[j]]];
		}
		pfactor[i, 3] = s;
	  }
	}
	//static ulong calc_key_from_pcs(ref int pcs, int mirror);
	internal static void free_wdl_entry(TBEntry entry)
	{
	  GlobalMembersTbcore.unmap_file(ref entry.data, entry.mapping);
	  if (entry.has_pawns == 0)
	  {
		TBEntry_piece ptr = (TBEntry_piece)entry;
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
		free(ptr.precomp[0]);
		if (ptr.precomp[1] != null)
		{
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
		  free(ptr.precomp[1]);
		}
	  }
	  else
	  {
		TBEntry_pawn ptr = (TBEntry_pawn)entry;
		int f;
		for (f = 0; f < 4; f++)
		{
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
		  free(ptr.file[f].precomp[0]);
		  if (ptr.file[f].precomp[1] != null)
		  {
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
			free(ptr.file[f].precomp[1]);
		  }
		}
	  }
	}
	internal static void free_dtz_entry(TBEntry entry)
	{
	  GlobalMembersTbcore.unmap_file(ref entry.data, entry.mapping);
	  if (entry.has_pawns == 0)
	  {
		DTZEntry_piece ptr = (DTZEntry_piece)entry;
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
		free(ptr.precomp);
	  }
	  else
	  {
		DTZEntry_pawn ptr = (DTZEntry_pawn)entry;
		int f;
		for (f = 0; f < 4; f++)
		{
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
		  free(ptr.file[f].precomp);
		}
	  }
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
	  free(entry);
	}

	internal static FD open_tb(string str, string suffix)
	{
	  int i;
	  FD fd = new FD();
	  string file = new string(new char[256]);

	  for (i = 0; i < num_paths; i++)
	  {
		file = paths[i];
		file += "/";
		file += str;
		file += suffix;
	#if ! _WIN32
		fd = open(file, O_RDONLY);
	#else
		fd = CreateFile(file, GENERIC_READ, FILE_SHARE_READ, null, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, null);
	#endif
		if (fd != DefineConstants.FD_ERR)
		{
			return fd;
		}
	  }
	  return DefineConstants.FD_ERR;
	}

	internal static void close_tb(FD fd)
	{
	#if ! _WIN32
	  close(fd);
	#else
	  CloseHandle(fd);
	#endif
	}

	internal static string map_file(string name, string suffix, ref ulong mapping)
	{
	  FD fd = GlobalMembersTbcore.open_tb(name, suffix);
	  if (fd == DefineConstants.FD_ERR)
	  {
		return null;
	  }
	#if ! _WIN32
	  stat statbuf = new stat();
	  fstat(fd, statbuf);
	  mapping = statbuf.st_size;
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: sbyte *data = (sbyte *)mmap(null, statbuf.st_size, PROT_READ, MAP_SHARED, fd, 0);
	  sbyte data = (string)mmap(null, statbuf.st_size, PROT_READ, MAP_SHARED, fd, 0);
	  if (data == (string)(-1))
	  {
		Console.Write("Could not mmap() {0}.\n", name);
		Environment.Exit(1);
	  }
	#else
	  uint size_low;
	  uint size_high;
	  size_low = GetFileSize(fd, size_high);
	//  *size = ((uint64)size_high) << 32 | ((uint64)size_low);
	  System.IntPtr map = CreateFileMapping(fd, null, PAGE_READONLY, size_high, size_low, null);
	  if (map == null)
	  {
		Console.Write("CreateFileMapping() failed.\n");
		Environment.Exit(1);
	  }
	  mapping = (ulong)map;
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: sbyte *data = (sbyte *)MapViewOfFile(map, FILE_MAP_READ, 0, 0, 0);
	  sbyte data = (string)MapViewOfFile(map, FILE_MAP_READ, 0, 0, 0);
	  if (data == null)
	  {
		Console.Write("MapViewOfFile() failed, name = {0}{1}, error = {2:D}.\n", name, suffix, GetLastError());
		Environment.Exit(1);
	  }
	#endif
	  GlobalMembersTbcore.close_tb(fd);
	  return data;
	}

	#if ! _WIN32
	internal static void unmap_file(ref string data, ulong size)
	{
	  if (data == 0)
		  return;
	  munmap(data, size);
	}
	#else
	internal static void unmap_file(ref string data, ulong mapping)
	{
	  if (data == 0)
		  return;
	  UnmapViewOfFile(data);
	  CloseHandle((System.IntPtr)mapping);
	}
	#endif

	internal static void add_to_hash(TBEntry ptr, ulong key)
	{
	  int i;
	  int hshidx;

	  hshidx = key >> (64 - DefineConstants.TBHASHBITS);
	  i = 0;
	  while (i < DefineConstants.HSHMAX && TB_hash[hshidx, i].ptr != null)
	  {
		i++;
	  }
	  if (i == DefineConstants.HSHMAX)
	  {
		Console.Write("HSHMAX too low!\n");
		Environment.Exit(1);
	  }
	  else
	  {
		TB_hash[hshidx, i].key = key;
		TB_hash[hshidx, i].ptr = ptr;
	  }
	}

	internal static string pchr = "KQRBNP";

	internal static void init_tb(ref string str)
	{
	  FD fd = new FD();
	  TBEntry entry;
	  int i;
	  int j;
	  int[] pcs = new int[16];
	  ulong key;
	  ulong key2;
	  int color;
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
	  sbyte * s;

	  fd = GlobalMembersTbcore.open_tb(str, DefineConstants.WDLSUFFIX);
	  if (fd == DefineConstants.FD_ERR)
		  return;
	  GlobalMembersTbcore.close_tb(fd);

	  for (i = 0; i < 16; i++)
	  {
		pcs[i] = 0;
	  }
	  color = 0;
	  for (s = str; * s; s++)
	  {
		switch (*s)
		{
		case 'P':
		  pcs[DefineConstants.TB_PAWN | color]++;
		  break;
		case 'N':
		  pcs[DefineConstants.TB_KNIGHT | color]++;
		  break;
		case 'B':
		  pcs[DefineConstants.TB_BISHOP | color]++;
		  break;
		case 'R':
		  pcs[DefineConstants.TB_ROOK | color]++;
		  break;
		case 'Q':
		  pcs[DefineConstants.TB_QUEEN | color]++;
		  break;
		case 'K':
		  pcs[DefineConstants.TB_KING | color]++;
		  break;
		case 'v':
		  color = 0x08;
		  break;
		}
	  }
	  for (i = 0; i < 8; i++)
	  {
		if (pcs[i] != pcs[i + 8])
		  break;
	  }
	  key = GlobalMembersTbprobe.calc_key_from_pcs(pcs, 0);
	  key2 = GlobalMembersTbprobe.calc_key_from_pcs(pcs, 1);
	  if (pcs[DefineConstants.TB_PAWN] + pcs[DefineConstants.TB_PAWN | 8] == 0)
	  {
		if (TBnum_piece == DefineConstants.TBMAX_PIECE)
		{
		  Console.Write("TBMAX_PIECE limit too low!\n");
		  Environment.Exit(1);
		}
		entry = (TBEntry) TB_piece[TBnum_piece++];
	  }
	  else
	  {
		if (TBnum_pawn == DefineConstants.TBMAX_PAWN)
		{
		  Console.Write("TBMAX_PAWN limit too low!\n");
		  Environment.Exit(1);
		}
		entry = (TBEntry) TB_pawn[TBnum_pawn++];
	  }
	  entry.key = key;
	  entry.ready = 0;
	  entry.num = 0;
	  for (i = 0; i < 16; i++)
	  {
		entry.num += (byte)pcs[i];
	  }
	  entry.symmetric = (key == key2);
	  entry.has_pawns = (pcs[DefineConstants.TB_PAWN] + pcs[DefineConstants.TB_PAWN | 8] > 0);
	  if (entry.num > GlobalMembersTbprobe.MaxCardinality)
	  {
		GlobalMembersTbprobe.MaxCardinality = entry.num;
	  }

	  if (entry.has_pawns != 0)
	  {
		TBEntry_pawn ptr = (TBEntry_pawn)entry;
		ptr.pawns[0] = (byte)pcs[DefineConstants.TB_PAWN];
		ptr.pawns[1] = (byte)pcs[DefineConstants.TB_PAWN | 8];
		if (pcs[DefineConstants.TB_PAWN | 8] > 0 && (pcs[DefineConstants.TB_PAWN] == 0 || pcs[DefineConstants.TB_PAWN | 8] < pcs[DefineConstants.TB_PAWN]))
		{
		  ptr.pawns[0] = (byte)pcs[DefineConstants.TB_PAWN | 8];
		  ptr.pawns[1] = (byte)pcs[DefineConstants.TB_PAWN];
		}
	  }
	  else
	  {
		TBEntry_piece ptr = (TBEntry_piece)entry;
		for (i = 0, j = 0; i < 16; i++)
		{
		  if (pcs[i] == 1)
		  {
			  j++;
		  }
		}
		if (j >= 3)
		{
			ptr.enc_type = 0;
		}
		else if (j == 2)
		{
			ptr.enc_type = 2;
		}
		else // only for suicide
		{
		  j = 16;
		  for (i = 0; i < 16; i++)
		  {
			if (pcs[i] < j && pcs[i] > 1)
			{
				j = pcs[i];
			}
			ptr.enc_type = (byte)(1 + j);
		  }
		}
	  }
	  GlobalMembersTbcore.add_to_hash(entry, key);
	  if (key2 != key)
	  {
		  GlobalMembersTbcore.add_to_hash(entry, key2);
	  }
	}

	internal const string offdiag = {0,-1,-1,-1,-1,-1,-1,-1, 1, 0,-1,-1,-1,-1,-1,-1, 1, 1, 0,-1,-1,-1,-1,-1, 1, 1, 1, 0,-1,-1,-1,-1, 1, 1, 1, 1, 0,-1,-1,-1, 1, 1, 1, 1, 1, 0,-1,-1, 1, 1, 1, 1, 1, 1, 0,-1, 1, 1, 1, 1, 1, 1, 1, 0};

	internal readonly byte[] triangle = {6, 0, 1, 2, 2, 1, 0, 6, 0, 7, 3, 4, 4, 3, 7, 0, 1, 3, 8, 5, 5, 8, 3, 1, 2, 4, 5, 9, 9, 5, 4, 2, 2, 4, 5, 9, 9, 5, 4, 2, 1, 3, 8, 5, 5, 8, 3, 1, 0, 7, 3, 4, 4, 3, 7, 0, 6, 0, 1, 2, 2, 1, 0, 6};

	internal readonly byte[] invtriangle = {1, 2, 3, 10, 11, 19, 0, 9, 18, 27};

	internal readonly byte[] invdiag = {0, 9, 18, 27, 36, 45, 54, 63, 7, 14, 21, 28, 35, 42, 49, 56};

	internal readonly byte[] flipdiag = {0, 8, 16, 24, 32, 40, 48, 56, 1, 9, 17, 25, 33, 41, 49, 57, 2, 10, 18, 26, 34, 42, 50, 58, 3, 11, 19, 27, 35, 43, 51, 59, 4, 12, 20, 28, 36, 44, 52, 60, 5, 13, 21, 29, 37, 45, 53, 61, 6, 14, 22, 30, 38, 46, 54, 62, 7, 15, 23, 31, 39, 47, 55, 63};

	internal readonly byte[] lower = {28, 0, 1, 2, 3, 4, 5, 6, 0, 29, 7, 8, 9, 10, 11, 12, 1, 7, 30, 13, 14, 15, 16, 17, 2, 8, 13, 31, 18, 19, 20, 21, 3, 9, 14, 18, 32, 22, 23, 24, 4, 10, 15, 19, 22, 33, 25, 26, 5, 11, 16, 20, 23, 25, 34, 27, 6, 12, 17, 21, 24, 26, 27, 35};

	internal readonly byte[] diag = {0, 0, 0, 0, 0, 0, 0, 8, 0, 1, 0, 0, 0, 0, 9, 0, 0, 0, 2, 0, 0, 10, 0, 0, 0, 0, 0, 3, 11, 0, 0, 0, 0, 0, 0, 12, 4, 0, 0, 0, 0, 0, 13, 0, 0, 5, 0, 0, 0, 14, 0, 0, 0, 0, 6, 0, 15, 0, 0, 0, 0, 0, 0, 7};

	internal readonly byte[] flap = {0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 12, 18, 18, 12, 6, 0, 1, 7, 13, 19, 19, 13, 7, 1, 2, 8, 14, 20, 20, 14, 8, 2, 3, 9, 15, 21, 21, 15, 9, 3, 4, 10, 16, 22, 22, 16, 10, 4, 5, 11, 17, 23, 23, 17, 11, 5, 0, 0, 0, 0, 0, 0, 0, 0};

	internal readonly byte[] ptwist = {0, 0, 0, 0, 0, 0, 0, 0, 47, 35, 23, 11, 10, 22, 34, 46, 45, 33, 21, 9, 8, 20, 32, 44, 43, 31, 19, 7, 6, 18, 30, 42, 41, 29, 17, 5, 4, 16, 28, 40, 39, 27, 15, 3, 2, 14, 26, 38, 37, 25, 13, 1, 0, 12, 24, 36, 0, 0, 0, 0, 0, 0, 0, 0};

	internal readonly byte[] invflap = {8, 16, 24, 32, 40, 48, 9, 17, 25, 33, 41, 49, 10, 18, 26, 34, 42, 50, 11, 19, 27, 35, 43, 51};

	internal readonly byte[] invptwist = {52, 51, 44, 43, 36, 35, 28, 27, 20, 19, 12, 11, 53, 50, 45, 42, 37, 34, 29, 26, 21, 18, 13, 10, 54, 49, 46, 41, 38, 33, 30, 25, 22, 17, 14, 9, 55, 48, 47, 40, 39, 32, 31, 24, 23, 16, 15, 8};

	internal readonly byte[] file_to_file = {0, 1, 2, 3, 3, 2, 1, 0};

	internal readonly short[,] KK_idx = {{-1, -1, -1, 0, 1, 2, 3, 4, -1, -1, -1, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57}, {58, -1, -1, -1, 59, 60, 61, 62, 63, -1, -1, -1, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100,101,102,103,104,105,106,107, 108,109,110,111,112,113,114,115}, {116,117, -1, -1, -1,118,119,120, 121,122, -1, -1, -1,123,124,125, 126,127,128,129,130,131,132,133, 134,135,136,137,138,139,140,141, 142,143,144,145,146,147,148,149, 150,151,152,153,154,155,156,157, 158,159,160,161,162,163,164,165, 166,167,168,169,170,171,172,173}, {174, -1, -1, -1,175,176,177,178, 179, -1, -1, -1,180,181,182,183, 184, -1, -1, -1,185,186,187,188, 189,190,191,192,193,194,195,196, 197,198,199,200,201,202,203,204, 205,206,207,208,209,210,211,212, 213,214,215,216,217,218,219,220, 221,222,223,224,225,226,227,228}, {229,230, -1, -1, -1,231,232,233, 234,235, -1, -1, -1,236,237,238, 239,240, -1, -1, -1,241,242,243, 244,245,246,247,248,249,250,251, 252,253,254,255,256,257,258,259, 260,261,262,263,264,265,266,267, 268,269,270,271,272,273,274,275, 276,277,278,279,280,281,282,283}, {284,285,286,287,288,289,290,291, 292,293, -1, -1, -1,294,295,296, 297,298, -1, -1, -1,299,300,301, 302,303, -1, -1, -1,304,305,306, 307,308,309,310,311,312,313,314, 315,316,317,318,319,320,321,322, 323,324,325,326,327,328,329,330, 331,332,333,334,335,336,337,338}, {-1, -1,339,340,341,342,343,344, -1, -1,345,346,347,348,349,350, -1, -1,441,351,352,353,354,355, -1, -1, -1,442,356,357,358,359, -1, -1, -1, -1,443,360,361,362, -1, -1, -1, -1, -1,444,363,364, -1, -1, -1, -1, -1, -1,445,365, -1, -1, -1, -1, -1, -1, -1,446}, {-1, -1, -1,366,367,368,369,370, -1, -1, -1,371,372,373,374,375, -1, -1, -1,376,377,378,379,380, -1, -1, -1,447,381,382,383,384, -1, -1, -1, -1,448,385,386,387, -1, -1, -1, -1, -1,449,388,389, -1, -1, -1, -1, -1, -1,450,390, -1, -1, -1, -1, -1, -1, -1,451}, {452,391,392,393,394,395,396,397, -1, -1, -1, -1,398,399,400,401, -1, -1, -1, -1,402,403,404,405, -1, -1, -1, -1,406,407,408,409, -1, -1, -1, -1,453,410,411,412, -1, -1, -1, -1, -1,454,413,414, -1, -1, -1, -1, -1, -1,455,415, -1, -1, -1, -1, -1, -1, -1,456}, {457,416,417,418,419,420,421,422, -1,458,423,424,425,426,427,428, -1, -1, -1, -1, -1,429,430,431, -1, -1, -1, -1, -1,432,433,434, -1, -1, -1, -1, -1,435,436,437, -1, -1, -1, -1, -1,459,438,439, -1, -1, -1, -1, -1, -1,460,440, -1, -1, -1, -1, -1, -1, -1,461}};

	internal static int[,] binomial = new int[5, 64];
	internal static int[,] pawnidx = new int[5, 24];
	internal static int[,] pfactor = new int[5, 4];

	internal static ulong encode_piece(TBEntry_piece ptr, byte[] norm, int[] pos, int[] factor)
	{
	  ulong idx;
	  int i;
	  int j;
	  int k;
	  int m;
	  int l;
	  int p;
	  int n = ptr.num;

	  if (pos[0] & 0x04)
	  {
		for (i = 0; i < n; i++)
		{
		  pos[i] ^= 0x07;
		}
	  }
	  if (pos[0] & 0x20)
	  {
		for (i = 0; i < n; i++)
		{
		  pos[i] ^= 0x38;
		}
	  }

	  for (i = 0; i < n; i++)
	  {
		if (offdiag[pos[i]])
			break;
	  }
	  if (i < (ptr.enc_type == 0 ? 3 : 2) && offdiag[pos[i]] > 0)
	  {
		for (i = 0; i < n; i++)
		{
		  pos[i] = flipdiag[pos[i]];
		}
	  }

	  switch (ptr.enc_type)
	  {

	  case 0: // 111
		i = (pos[1] > pos[0]);
		j = (pos[2] > pos[0]) + (pos[2] > pos[1]);

		if (offdiag[pos[0]])
		{
		  idx = triangle[pos[0]] * 63 * 62 + (pos[1] - i) * 62 + (pos[2] - j);
		}
		else if (offdiag[pos[1]])
		{
		  idx = 6 * 63 * 62 + diag[pos[0]] * 28 * 62 + lower[pos[1]] * 62 + pos[2] - j;
		}
		else if (offdiag[pos[2]])
		{
		  idx = 6 * 63 * 62 + 4 * 28 * 62 + (diag[pos[0]]) * 7 * 28 + (diag[pos[1]] - i) * 28 + lower[pos[2]];
		}
		else
		{
		  idx = 6 * 63 * 62 + 4 * 28 * 62 + 4 * 7 * 28 + (diag[pos[0]] * 7 * 6) + (diag[pos[1]] - i) * 6 + (diag[pos[2]] - j);
		}
		i = 3;
		break;

	  case 1: // K3
		j = (pos[2] > pos[0]) + (pos[2] > pos[1]);

		idx = KK_idx[triangle[pos[0]], pos[1]];
		if (idx < 441)
		{
		  idx = idx + 441 * (pos[2] - j);
		}
		else
		{
		  idx = 441 * 62 + (idx - 441) + 21 * lower[pos[2]];
		  if (!offdiag[pos[2]])
		  {
			idx -= j * 21;
		  }
		}
		i = 3;
		break;

	  default: // K2
		idx = KK_idx[triangle[pos[0]], pos[1]];
		i = 2;
		break;
	  }
	  idx *= factor[0];

	  for (; i < n;)
	  {
		int t = norm[i];
		for (j = i; j < i + t; j++)
		{
		  for (k = j + 1; k < i + t; k++)
		  {
			if (pos[j] > pos[k])
			{
					int tmp = pos[j];
					pos[j] = pos[k];
					pos[k] = tmp;
			};
		  }
		}
		int s = 0;
		for (m = i; m < i + t; m++)
		{
		  p = pos[m];
		  for (l = 0, j = 0; l < i; l++)
		  {
			j += (p > pos[l]);
		  }
		  s += binomial[m - i, p - j];
		}
		idx += ((ulong)s) * ((ulong)factor[i]);
		i += t;
	  }

	  return idx;
	}

	// determine file of leftmost pawn and sort pawns
	internal static int pawn_file(TBEntry_pawn ptr, int[] pos)
	{
	  int i;

	  for (i = 1; i < ptr.pawns[0]; i++)
	  {
		if (flap[pos[0]] > flap[pos[i]])
		{
			  int tmp = pos[0];
			  pos[0] = pos[i];
			  pos[i] = tmp;
		};
	  }

	  return file_to_file[pos[0] & 0x07];
	}

	internal static ulong encode_pawn(TBEntry_pawn ptr, byte[] norm, int[] pos, int[] factor)
	{
	  ulong idx;
	  int i;
	  int j;
	  int k;
	  int m;
	  int s;
	  int t;
	  int n = ptr.num;

	  if (pos[0] & 0x04)
	  {
		for (i = 0; i < n; i++)
		{
		  pos[i] ^= 0x07;
		}
	  }

	  for (i = 1; i < ptr.pawns[0]; i++)
	  {
		for (j = i + 1; j < ptr.pawns[0]; j++)
		{
		  if (ptwist[pos[i]] < ptwist[pos[j]])
		  {
				int tmp = pos[i];
				pos[i] = pos[j];
				pos[j] = tmp;
		  };
		}
	  }

	  t = ptr.pawns[0] - 1;
	  idx = pawnidx[t, flap[pos[0]]];
	  for (i = t; i > 0; i--)
	  {
		idx += binomial[t - i, ptwist[pos[i]]];
	  }
	  idx *= factor[0];

	// remaining pawns
	  i = ptr.pawns[0];
	  t = i + ptr.pawns[1];
	  if (t > i)
	  {
		for (j = i; j < t; j++)
		{
		  for (k = j + 1; k < t; k++)
		  {
			if (pos[j] > pos[k])
			{
					int tmp = pos[j];
					pos[j] = pos[k];
					pos[k] = tmp;
			};
		  }
		}
		s = 0;
		for (m = i; m < t; m++)
		{
		  int p = pos[m];
		  for (k = 0, j = 0; k < i; k++)
		  {
			j += (p > pos[k]);
		  }
		  s += binomial[m - i, p - j - 8];
		}
		idx += ((ulong)s) * ((ulong)factor[i]);
		i = t;
	  }

	  for (; i < n;)
	  {
		t = norm[i];
		for (j = i; j < i + t; j++)
		{
		  for (k = j + 1; k < i + t; k++)
		  {
			if (pos[j] > pos[k])
			{
					int tmp = pos[j];
					pos[j] = pos[k];
					pos[k] = tmp;
			};
		  }
		}
		s = 0;
		for (m = i; m < i + t; m++)
		{
		  int p = pos[m];
		  for (k = 0, j = 0; k < i; k++)
		  {
			j += (p > pos[k]);
		  }
		  s += binomial[m - i, p - j];
		}
		idx += ((ulong)s) * ((ulong)factor[i]);
		i += t;
	  }

	  return idx;
	}

	// place k like pieces on n squares
	internal static int subfactor(int k, int n)
	{
	  int i;
	  int f;
	  int l;

	  f = n;
	  l = 1;
	  for (i = 1; i < k; i++)
	  {
		f *= n - i;
		l *= i + 1;
	  }

	  return f / l;
	}
//C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
private static int[] calc_factors_piece_pivfac = {31332, 28056, 462};

	internal static ulong calc_factors_piece(int[] factor, int num, int order, byte[] norm, byte enc_type)
	{
	  int i;
	  int k;
	  int n;
	  ulong f;
	//C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
	//  static int pivfac[] = { 31332, 28056, 462 };

	  n = 64 - norm[0];

	  f = 1;
	  for (i = norm[0], k = 0; i < num || k == order; k++)
	  {
		if (k == order)
		{
		  factor[0] = (int)(f);
		  f *= calc_factors_piece_pivfac[enc_type];
		}
		else
		{
		  factor[i] = (int)(f);
		  f *= GlobalMembersTbcore.subfactor(norm[i], n);
		  n -= norm[i];
		  i += norm[i];
		}
	  }

	  return f;
	}

	internal static ulong calc_factors_pawn(int[] factor, int num, int order, int order2, byte[] norm, int file)
	{
	  int i;
	  int k;
	  int n;
	  ulong f;

	  i = norm[0];
	  if (order2 < 0x0f)
	  {
		  i += norm[i];
	  }
	  n = 64 - i;

	  f = 1;
	  for (k = 0; i < num || k == order || k == order2; k++)
	  {
		if (k == order)
		{
		  factor[0] = (int)(f);
		  f *= pfactor[norm[0] - 1, file];
		}
		else if (k == order2)
		{
		  factor[norm[0]] = (int)(f);
		  f *= GlobalMembersTbcore.subfactor(norm[norm[0]], 48 - norm[0]);
		}
		else
		{
		  factor[i] = (int)(f);
		  f *= GlobalMembersTbcore.subfactor(norm[i], n);
		  n -= norm[i];
		  i += norm[i];
		}
	  }

	  return f;
	}

	internal static void set_norm_piece(TBEntry_piece ptr, byte[] norm, byte[] pieces)
	{
	  int i;
	  int j;

	  for (i = 0; i < ptr.num; i++)
	  {
		norm[i] = 0;
	  }

	  switch (ptr.enc_type)
	  {
	  case 0:
		norm[0] = 3;
		break;
	  case 2:
		norm[0] = 2;
		break;
	  default:
		norm[0] = (byte)(ptr.enc_type - 1);
		break;
	  }

	  for (i = norm[0]; i < ptr.num; i += norm[i])
	  {
		for (j = i; j < ptr.num && pieces[j] == pieces[i]; j++)
		{
		  norm[i]++;
		}
	  }
	}

	internal static void set_norm_pawn(TBEntry_pawn ptr, byte[] norm, byte[] pieces)
	{
	  int i;
	  int j;

	  for (i = 0; i < ptr.num; i++)
	  {
		norm[i] = 0;
	  }

	  norm[0] = ptr.pawns[0];
	  if (ptr.pawns[1] != 0)
	  {
		  norm[ptr.pawns[0]] = ptr.pawns[1];
	  }

	  for (i = ptr.pawns[0] + ptr.pawns[1]; i < ptr.num; i += norm[i])
	  {
		for (j = i; j < ptr.num && pieces[j] == pieces[i]; j++)
		{
		  norm[i]++;
		}
	  }
	}

	internal static void setup_pieces_piece(TBEntry_piece ptr, byte[] data, ulong[] tb_size)
	{
	  int i;
	  int order;

	  for (i = 0; i < ptr.num; i++)
	  {
		ptr.pieces[0, i] = (byte)(data[i + 1] & 0x0f);
	  }
	  order = data[0] & 0x0f;
	  GlobalMembersTbcore.set_norm_piece(ptr, ptr.norm[0], ptr.pieces[0]);
	  tb_size[0] = GlobalMembersTbcore.calc_factors_piece(ptr.factor[0], ptr.num, order, ptr.norm[0], ptr.enc_type);

	  for (i = 0; i < ptr.num; i++)
	  {
		ptr.pieces[1, i] = (byte)(data[i + 1] >> 4);
	  }
	  order = data[0] >> 4;
	  GlobalMembersTbcore.set_norm_piece(ptr, ptr.norm[1], ptr.pieces[1]);
	  tb_size[1] = GlobalMembersTbcore.calc_factors_piece(ptr.factor[1], ptr.num, order, ptr.norm[1], ptr.enc_type);
	}

	internal static void setup_pieces_piece_dtz(DTZEntry_piece ptr, byte[] data, ulong[] tb_size)
	{
	  int i;
	  int order;

	  for (i = 0; i < ptr.num; i++)
	  {
		ptr.pieces[i] = (byte)(data[i + 1] & 0x0f);
	  }
	  order = data[0] & 0x0f;
	  GlobalMembersTbcore.set_norm_piece((TBEntry_piece)ptr, ptr.norm, ptr.pieces);
	  tb_size[0] = GlobalMembersTbcore.calc_factors_piece(ptr.factor, ptr.num, order, ptr.norm, ptr.enc_type);
	}

	internal static void setup_pieces_pawn(TBEntry_pawn ptr, byte[] data, ulong[] tb_size, int f)
	{
	  int i;
	  int j;
	  int order;
	  int order2;

	  j = 1 + (ptr.pawns[1] > 0);
	  order = data[0] & 0x0f;
	  order2 = ptr.pawns[1] != 0 ? (data[1] & 0x0f) : 0x0f;
	  for (i = 0; i < ptr.num; i++)
	  {
		ptr.file[f].pieces[0, i] = (byte)(data[i + j] & 0x0f);
	  }
	  GlobalMembersTbcore.set_norm_pawn(ptr, ptr.file[f].norm[0], ptr.file[f].pieces[0]);
	  tb_size[0] = GlobalMembersTbcore.calc_factors_pawn(ptr.file[f].factor[0], ptr.num, order, order2, ptr.file[f].norm[0], f);

	  order = data[0] >> 4;
	  order2 = ptr.pawns[1] != 0 ? (data[1] >> 4) : 0x0f;
	  for (i = 0; i < ptr.num; i++)
	  {
		ptr.file[f].pieces[1, i] = (byte)(data[i + j] >> 4);
	  }
	  GlobalMembersTbcore.set_norm_pawn(ptr, ptr.file[f].norm[1], ptr.file[f].pieces[1]);
	  tb_size[1] = GlobalMembersTbcore.calc_factors_pawn(ptr.file[f].factor[1], ptr.num, order, order2, ptr.file[f].norm[1], f);
	}

	internal static void setup_pieces_pawn_dtz(DTZEntry_pawn ptr, byte[] data, ulong[] tb_size, int f)
	{
	  int i;
	  int j;
	  int order;
	  int order2;

	  j = 1 + (ptr.pawns[1] > 0);
	  order = data[0] & 0x0f;
	  order2 = ptr.pawns[1] != 0 ? (data[1] & 0x0f) : 0x0f;
	  for (i = 0; i < ptr.num; i++)
	  {
		ptr.file[f].pieces[i] = (byte)(data[i + j] & 0x0f);
	  }
	  GlobalMembersTbcore.set_norm_pawn((TBEntry_pawn)ptr, ptr.file[f].norm, ptr.file[f].pieces);
	  tb_size[0] = GlobalMembersTbcore.calc_factors_pawn(ptr.file[f].factor, ptr.num, order, order2, ptr.file[f].norm, f);
	}

	internal static void calc_symlen(PairsData d, int s, ref string tmp)
	{
	  int s1;
	  int s2;

	  byte[] w = d.sympat + 3 * s;
	  s2 = (w[2] << 4) | (w[1] >> 4);
	  if (s2 == 0x0fff)
	  {
		d.symlen[s] = 0;
	  }
	  else
	  {
		s1 = ((w[1] & 0xf) << 8) | w[0];
		if (!tmp[s1])
		{
			GlobalMembersTbcore.calc_symlen(d, s1, ref tmp);
		}
		if (!tmp[s2])
		{
			GlobalMembersTbcore.calc_symlen(d, s2, ref tmp);
		}
		d.symlen[s] = (byte)(d.symlen[s1] + d.symlen[s2] + 1);
	  }
	  tmp[s] = 1;
	}

	public static ushort ReadUshort(byte[] d)
	{
	  return (ushort)(d[0] | (d[1] << 8));
	}

	public static uint ReadUint32(byte[] d)
	{
	  return d[0] | (d[1] << 8) | (d[2] << 16) | (d[3] << 24);
	}

	internal static PairsData setup_pairs(byte[] data, ulong tb_size, ulong[] size, byte[][] next, ref byte flags, int wdl)
	{
	  PairsData d;
	  int i;

	  flags = data[0];
	  if (data[0] & 0x80)
	  {
//C++ TO C# CONVERTER TODO TASK: The memory management function 'malloc' has no equivalent in C#:
		d = (PairsData)malloc(sizeof(PairsData));
		d.idxbits = 0;
		if (wdl != 0)
		{
		  d.min_len = data[1];
		}
		else
		{
		  d.min_len = 0;
		}
		next = data + 2;
		size[0] = size[1] = size[2] = 0;
		return d;
	  }

	  int blocksize = data[1];
	  int idxbits = data[2];
	  int real_num_blocks = GlobalMembersTbcore.ReadUint32(data[4]);
	  int num_blocks = real_num_blocks + (byte)(data[3]);
	  int max_len = data[8];
	  int min_len = data[9];
	  int h = max_len - min_len + 1;
	  int num_syms = GlobalMembersTbcore.ReadUshort(data[10 + 2 * h]);
//C++ TO C# CONVERTER TODO TASK: The memory management function 'malloc' has no equivalent in C#:
	  d = (PairsData)malloc(sizeof(PairsData) + (h - 1) * sizeof(ulong) + num_syms);
	  d.blocksize = blocksize;
	  d.idxbits = idxbits;
	  d.offset = (ushort)(data[10]);
	  d.symlen = ((byte)d) + sizeof(PairsData) + (h - 1) * sizeof(ulong);
	  d.sympat = data[12 + 2 * h];
	  d.min_len = min_len;
	  next = &data[12 + 2 * h + 3 * num_syms + (num_syms & 1)];

	  ulong num_indices = (tb_size + (1UL << idxbits) - 1) >> idxbits;
	  size[0] = 6UL * num_indices;
	  size[1] = 2UL * num_blocks;
	  size[2] = (1UL << blocksize) * real_num_blocks;

	  // char tmp[num_syms];
	  string tmp = new string(new char[4096]);
	  for (i = 0; i < num_syms; i++)
	  {
		tmp = StringFunctions.ChangeCharacter(tmp, i, 0);
	  }
	  for (i = 0; i < num_syms; i++)
	  {
		if (!tmp[i])
		{
		  GlobalMembersTbcore.calc_symlen(d, i, ref tmp);
		}
	  }

	  d.@base[h - 1] = 0;
	  for (i = h - 2; i >= 0; i--)
	  {
		d.@base[i] = (d.@base[i + 1] + GlobalMembersTbcore.ReadUshort((byte)(d.offset + i)) - GlobalMembersTbcore.ReadUshort((byte)(d.offset + i + 1))) / 2;
	  }
	  for (i = 0; i < h; i++)
	  {
		d.@base[i] <<= 64 - (min_len + i);
	  }

	  d.offset -= d.min_len;

	  return d;
	}

	internal static int init_table_wdl(TBEntry entry, ref string str)
	{
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: byte *next;
	  byte next;
	  int f;
	  int s;
	  ulong[] tb_size = new ulong[8];
	  ulong[] size = new ulong[8 * 3];
	  byte flags;

	  // first mmap the table into memory

	  entry.data = GlobalMembersTbcore.map_file(str, DefineConstants.WDLSUFFIX, ref entry.mapping);
	  if (entry.data == 0)
	  {
		Console.Write("Could not find {0}" DefineConstants.WDLSUFFIX, str);
		return 0;
	  }

	  byte[] data = (byte)entry.data;
	  if (data[0] != WDL_MAGIC[0] || data[1] != WDL_MAGIC[1] || data[2] != WDL_MAGIC[2] || data[3] != WDL_MAGIC[3])
	  {
		Console.Write("Corrupted table.\n");
		GlobalMembersTbcore.unmap_file(ref entry.data, entry.mapping);
		entry.data = 0;
		return 0;
	  }

	  int split = data[4] & 0x01;
	  int files = (data[4] & 0x02) != 0 ? 4 : 1;

	  data += 5;

	  if (entry.has_pawns == 0)
	  {
		TBEntry_piece ptr = (TBEntry_piece)entry;
		GlobalMembersTbcore.setup_pieces_piece(ptr, data, tb_size[0]);
		data += ptr.num + 1;
		data += ((ushort)data) & 0x01;

		ptr.precomp[0] = GlobalMembersTbcore.setup_pairs(data, tb_size[0], size[0], next, ref flags, 1);
		data = next;
		if (split != 0)
		{
		  ptr.precomp[1] = GlobalMembersTbcore.setup_pairs(data, tb_size[1], size[3], next, ref flags, 1);
		  data = next;
		}
		else
		{
		  ptr.precomp[1] = null;
		}

		ptr.precomp[0].indextable = (string)data;
		data += size[0];
		if (split != 0)
		{
		  ptr.precomp[1].indextable = (string)data;
		  data += size[3];
		}

		ptr.precomp[0].sizetable = (ushort)data;
		data += size[1];
		if (split != 0)
		{
		  ptr.precomp[1].sizetable = (ushort)data;
		  data += size[4];
		}

		data = (byte)((((ushort)data) + 0x3f) & ~0x3f);
		ptr.precomp[0].data = data;
		data += size[2];
		if (split != 0)
		{
		  data = (byte)((((ushort)data) + 0x3f) & ~0x3f);
		  ptr.precomp[1].data = data;
		}
	  }
	  else
	  {
		TBEntry_pawn ptr = (TBEntry_pawn)entry;
		s = 1 + (ptr.pawns[1] > 0);
		for (f = 0; f < 4; f++)
		{
		  GlobalMembersTbcore.setup_pieces_pawn((TBEntry_pawn)ptr, data, tb_size[2 * f], f);
		  data += ptr.num + s;
		}
		data += ((ushort)data) & 0x01;

		for (f = 0; f < files; f++)
		{
		  ptr.file[f].precomp[0] = GlobalMembersTbcore.setup_pairs(data, tb_size[2 * f], size[6 * f], next, ref flags, 1);
		  data = next;
		  if (split != 0)
		  {
			ptr.file[f].precomp[1] = GlobalMembersTbcore.setup_pairs(data, tb_size[2 * f + 1], size[6 * f + 3], next, ref flags, 1);
			data = next;
		  }
		  else
		  {
			ptr.file[f].precomp[1] = null;
		  }
		}

		for (f = 0; f < files; f++)
		{
		  ptr.file[f].precomp[0].indextable = (string)data;
		  data += size[6 * f];
		  if (split != 0)
		  {
			ptr.file[f].precomp[1].indextable = (string)data;
			data += size[6 * f + 3];
		  }
		}

		for (f = 0; f < files; f++)
		{
		  ptr.file[f].precomp[0].sizetable = (ushort)data;
		  data += size[6 * f + 1];
		  if (split != 0)
		  {
			ptr.file[f].precomp[1].sizetable = (ushort)data;
			data += size[6 * f + 4];
		  }
		}

		for (f = 0; f < files; f++)
		{
		  data = (byte)((((ushort)data) + 0x3f) & ~0x3f);
		  ptr.file[f].precomp[0].data = data;
		  data += size[6 * f + 2];
		  if (split != 0)
		  {
			data = (byte)((((ushort)data) + 0x3f) & ~0x3f);
			ptr.file[f].precomp[1].data = data;
			data += size[6 * f + 5];
		  }
		}
	  }

	  return 1;
	}

	internal static int init_table_dtz(TBEntry entry)
	{
	  byte[] data = (byte)entry.data;
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: byte *next;
	  byte next;
	  int f;
	  int s;
	  ulong[] tb_size = new ulong[4];
	  ulong[] size = new ulong[4 * 3];

	  if (!data)
	  {
		return 0;
	  }

	  if (data[0] != DTZ_MAGIC[0] || data[1] != DTZ_MAGIC[1] || data[2] != DTZ_MAGIC[2] || data[3] != DTZ_MAGIC[3])
	  {
		Console.Write("Corrupted table.\n");
		return 0;
	  }

	  int files = (data[4] & 0x02) != 0 ? 4 : 1;

	  data += 5;

	  if (entry.has_pawns == 0)
	  {
		DTZEntry_piece ptr = (DTZEntry_piece)entry;
		GlobalMembersTbcore.setup_pieces_piece_dtz(ptr, data, tb_size[0]);
		data += ptr.num + 1;
		data += ((ushort)data) & 0x01;

		ptr.precomp = GlobalMembersTbcore.setup_pairs(data, tb_size[0], size[0], next, ref (ptr.flags), 0);
		data = next;

		ptr.map = data;
		if ((ptr.flags & 2) != 0)
		{
		  int i;
		  for (i = 0; i < 4; i++)
		  {
			ptr.map_idx[i] = (ushort)(data + 1 - ptr.map);
			data += 1 + data[0];
		  }
		  data += ((ushort)data) & 0x01;
		}

		ptr.precomp.indextable = (string)data;
		data += size[0];

		ptr.precomp.sizetable = (ushort)data;
		data += size[1];

		data = (byte)((((ushort)data) + 0x3f) & ~0x3f);
		ptr.precomp.data = data;
		data += size[2];
	  }
	  else
	  {
		DTZEntry_pawn ptr = (DTZEntry_pawn)entry;
		s = 1 + (ptr.pawns[1] > 0);
		for (f = 0; f < 4; f++)
		{
		  GlobalMembersTbcore.setup_pieces_pawn_dtz(ptr, data, tb_size[f], f);
		  data += ptr.num + s;
		}
		data += ((ushort)data) & 0x01;

		for (f = 0; f < files; f++)
		{
		  ptr.file[f].precomp = GlobalMembersTbcore.setup_pairs(data, tb_size[f], size[3 * f], next, ref (ptr.flags[f]), 0);
		  data = next;
		}

		ptr.map = data;
		for (f = 0; f < files; f++)
		{
		  if ((ptr.flags[f] & 2) != 0)
		  {
			int i;
			for (i = 0; i < 4; i++)
			{
			  ptr.map_idx[f, i] = (ushort)(data + 1 - ptr.map);
			  data += 1 + data[0];
			}
		  }
		}
		data += ((ushort)data) & 0x01;

		for (f = 0; f < files; f++)
		{
		  ptr.file[f].precomp.indextable = (string)data;
		  data += size[3 * f];
		}

		for (f = 0; f < files; f++)
		{
		  ptr.file[f].precomp.sizetable = (ushort)data;
		  data += size[3 * f + 1];
		}

		for (f = 0; f < files; f++)
		{
		  data = (byte)((((ushort)data) + 0x3f) & ~0x3f);
		  ptr.file[f].precomp.data = data;
		  data += size[3 * f + 2];
		}
	  }

	  return 1;
	}

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<bool LittleEndian>
	internal static byte decompress_pairs<bool LittleEndian>(PairsData d, ulong idx)
	{
	  if (d.idxbits == 0)
	  {
		return (byte)d.min_len;
	  }

	  uint mainidx = (uint)(idx >> d.idxbits);
	  int litidx = (idx & ((1UL << d.idxbits) - 1)) - (1UL << (d.idxbits - 1));
	  uint block = (uint)(d.indextable.Substring(6) * mainidx);
	  if (!LittleEndian)
	  {
		block = BSWAP32(block);
	  }

	  ushort idxOffset = (ushort)(d.indextable.Substring(6) * mainidx + 4);
	  if (!LittleEndian)
	  {
		idxOffset = (ushort)((idxOffset << 8) | (idxOffset >> 8));
	  }
	  litidx += idxOffset;

	  if (litidx < 0)
	  {
		do
		{
		  litidx += d.sizetable[--block] + 1;
		} while (litidx < 0);
	  }
	  else
	  {
		while (litidx > d.sizetable[block])
		{
		  litidx -= d.sizetable[block++] + 1;
		}
	  }

//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
	  uint * ptr = (uint)(d.data + (block << d.blocksize));

	  int m = d.min_len;
	  ushort[] offset = d.offset;
	  ulong[] @base = d.@base - m;
	  byte[] symlen = d.symlen;
	  int sym;
	  int bitcnt;

	  ulong code = (ulong)ptr;
	  if (LittleEndian)
	  {
		code = BSWAP64(code);
	  }

	  ptr += 2;
	  bitcnt = 0; // number of "empty bits" in code
	  for (;;)
	  {
		int l = m;
		while (code < @base[l])
		{
			l++;
		}
		sym = offset[l];
		if (!LittleEndian)
		{
		  sym = ((sym & 0xff) << 8) | (sym >> 8);
		}
		sym += (int)((code - @base[l]) >> (64 - l));
		if (litidx < (int)symlen[sym] + 1)
			break;
		litidx -= (int)symlen[sym] + 1;
		code <<= l;
		bitcnt += l;
		if (bitcnt >= 32)
		{
		  bitcnt -= 32;
		  uint tmp = ptr++;
		  if (LittleEndian)
		  {
			tmp = BSWAP32(tmp);
		  }
		  code |= ((ulong)tmp) << bitcnt;
		}
	  }

//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent for pointers to value types:
//ORIGINAL LINE: byte *sympat = d->sympat;
	  byte sympat = d.sympat;
	  while (symlen[sym] != 0)
	  {
		byte[] w = sympat + (3 * sym);
		int s1 = ((w[1] & 0xf) << 8) | w[0];
		if (litidx < (int)symlen[s1] + 1)
		{
		  sym = s1;
		}
		else
		{
		  litidx -= (int)symlen[s1] + 1;
		  sym = (w[2] << 4) | (w[1] >> 4);
		}
	  }

	  return sympat[3 * sym];
	}

	public static void load_dtz_table(ref string str, ulong key1, ulong key2)
	{
	  int i;
	  TBEntry ptr;
	  TBEntry ptr3;
	  TBHashEntry[] ptr2;

	  DTZ_table[0].key1 = key1;
	  DTZ_table[0].key2 = key2;
	  DTZ_table[0].entry = null;

	  // find corresponding WDL entry
	  ptr2 = TB_hash[key1 >> (64 - DefineConstants.TBHASHBITS)];
	  for (i = 0; i < DefineConstants.HSHMAX; i++)
	  {
		if (ptr2[i].key == key1)
			break;
	  }
	  if (i == DefineConstants.HSHMAX)
		  return;
	  ptr = ptr2[i].ptr;

//C++ TO C# CONVERTER TODO TASK: The memory management function 'malloc' has no equivalent in C#:
	  ptr3 = (TBEntry)malloc(ptr.has_pawns != 0 ? sizeof(DTZEntry_pawn) : sizeof(DTZEntry_piece));

	  ptr3.data = GlobalMembersTbcore.map_file(str, DefineConstants.DTZSUFFIX, ref ptr3.mapping);
	  ptr3.key = ptr.key;
	  ptr3.num = ptr.num;
	  ptr3.symmetric = ptr.symmetric;
	  ptr3.has_pawns = ptr.has_pawns;
	  if (ptr3.has_pawns != 0)
	  {
		DTZEntry_pawn entry = (DTZEntry_pawn)ptr3;
		entry.pawns[0] = ((TBEntry_pawn)ptr).pawns[0];
		entry.pawns[1] = ((TBEntry_pawn)ptr).pawns[1];
	  }
	  else
	  {
		DTZEntry_piece entry = (DTZEntry_piece)ptr3;
		entry.enc_type = ((TBEntry_piece)ptr).enc_type;
	  }
	  if (GlobalMembersTbcore.init_table_dtz(ptr3) == 0)
	  {
//C++ TO C# CONVERTER TODO TASK: The memory management function 'free' has no equivalent in C#:
		free(ptr3);
	  }
	  else
	  {
		DTZ_table[0].entry = ptr3;
	  }
	}

	internal static int[] wdl_to_map = {1, 3, 0, 2, 0};
	internal static byte[] pa_flags = {8, 0, 0, 0, 4};
}


