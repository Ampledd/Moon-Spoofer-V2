﻿using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0000CA57 File Offset: 0x0000AC57
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
