﻿//106
// 
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// 
/* Rover Anti Gravity System
   * Copyright (C) 2015 Lunatic Aeronautics (ximrm and Tuareg)
   * Copyright (C) 2020 zer0Kerbal

   * This program is free software; you can redistribute it and/or modify
   * it under the terms of the GNU General Public License as published by
   * the Free Software Foundation; either version 2 of the License, or (at
   * your option) any later version.

   * This program is distributed in the hope that it will be useful, but
   * WITHOUT ANY WARRANTY; without even the implied warranty of
   * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
   * General Public License for more details.

   * You should have received a copy of the GNU General Public License
   * along with this program; if not, write to the Free Software
   * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307
   * USA.
*/
using System.Reflection;

[assembly: AssemblyFileVersion("1.4.0.106")]
[assembly: AssemblyVersion("1.4.0.0")]
[assembly: AssemblyInformationalVersion("1.4.0")]
[assembly: KSPAssembly("RoverAntiGravitySystem", 1,4,0)]

namespace RoverAntiGravitySystem
{
	public static class Version
	{
		public const int major = 1;
		public const int minor = 4;
		public const int patch = 0;
		public const int build = 0;
		public const string Number = "1.4.0.0";
#if DEBUG
        public const string Text = Number + "-zed'K BETA DEBUG";
        public const string SText = Number + "-zed'K BETA DEBUG";
#else
        public const string Text = Number + "-zed'K";
		public const string SText = Number;
#endif
	}
}