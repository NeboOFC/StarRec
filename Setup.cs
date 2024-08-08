﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace start
{
	class Setup
	{
		public static bool firsttime = false;
		public static void setup()
		{
			//sets up all the important files so Starrec doesnt crash like lame vaultserver xD
			Console.WriteLine("Setting up... (May take a minute to download everything.)");
			Directory.CreateDirectory("SaveData\\App\\");
			Directory.CreateDirectory("SaveData\\Profile\\");
			Directory.CreateDirectory("SaveData\\Images\\");
			Directory.CreateDirectory("SaveData\\Rooms\\");
			Directory.CreateDirectory("SaveData\\Images\\");
			Directory.CreateDirectory("SaveData\\Rooms\\Downloaded\\");
			if (!(File.Exists("SaveData\\App\\firsttime.txt")))
			{
				File.WriteAllText("SaveData\\App\\firsttime.txt", "this text file has no use other than to tell the program whether to bring up the intro or not, so i can just write random shit here. among us balls, you suck mad dick you big fat fa----");
				firsttime = true;
			}
			if (!(File.Exists("SaveData\\avatar.txt")))
			{
				File.WriteAllText("SaveData\\avatar.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/avatar.txt"));
			}
			else if (File.ReadAllText("SaveData\\avatar.txt") == "")
            {
				File.WriteAllText("SaveData\\avatar.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/avatar.txt"));
			}
			if (!(File.Exists("SaveData\\avataritems.txt")))
			{
				File.WriteAllText("SaveData\\avataritems.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/avataritems.txt"));
			}
			if (!(File.Exists("SaveData\\avataritems2.txt")))
			{
				File.WriteAllText("SaveData\\avataritems2.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/avataritems2.txt"));
			}
			if (!(File.Exists("SaveData\\equipment.txt")))
			{
				File.WriteAllText("SaveData\\equipment.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/equipment.txt"));
			}
			if (!(File.Exists("SaveData\\consumables.txt")))
			{
				File.WriteAllText("SaveData\\consumables.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/consumables.txt"));
			}
			if (!(File.Exists("SaveData\\gameconfigs.txt")))
			{
				File.WriteAllText("SaveData\\gameconfigs.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/gameconfigs.txt"));
			}
			if (!(File.Exists("SaveData\\storefronts2.txt")))
			{
				File.WriteAllText("SaveData\\storefronts2.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/storefront2.txt"));
			}
			if (!(File.Exists("SaveData\\baserooms.txt")))
			{
				File.WriteAllText("SaveData\\baserooms.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/baserooms.txt"));
			}
			if (!(File.Exists("SaveData\\Profile\\username.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\username.txt", "StarRec User#" + new Random().Next(0, 1000000));
			}
			if (!(File.Exists("SaveData\\Profile\\level.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\level.txt", "10");
			}
			if (!(File.Exists("SaveData\\Profile\\userid.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\userid.txt", "10000000");
			}
			if (!(File.Exists("SaveData\\myrooms.txt")))
			{
				File.WriteAllText("SaveData\\myrooms.txt", "[]");
			}
			if (!(File.Exists("SaveData\\settings.txt")))
			{
				File.WriteAllText("SaveData\\settings.txt", Newtonsoft.Json.JsonConvert.SerializeObject(api.Settings.CreateDefaultSettings()));
			}	
			if (!(File.Exists("SaveData\\profileimage.png")))
			{
				File.WriteAllBytes("SaveData\\profileimage.png", new WebClient().DownloadData("https://raw.githubusercontent.com/NeboOFC/StarRec/main/profileimage.png"));
			}
			if (!(File.Exists("SaveData\\App\\privaterooms.txt")))
			{
				File.WriteAllText("SaveData\\App\\privaterooms.txt", "Disabled");
			}
			if (!(File.Exists("SaveData\\App\\showstarrecinfo.txt")))
			{
				File.WriteAllText("SaveData\\App\\showstarrecinfo.txt", "Enabled");
			}
			if (!(File.Exists("SaveData\\App\\facefeaturesadd.txt")))
			{
				File.WriteAllText("SaveData\\App\\facefeaturesadd.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/NeboOFC/StarRec/main/Download/facefeaturesadd.txt"));
			}
			goto tryagain;

		tryagain:
			if (!File.Exists("SaveData\\Rooms\\Downloaded\\roomname.txt"))
            {
				try
				{
					api.CustomRooms.RoomGet("gizmoface");
				}
				catch
				{
					goto tryagain;
				}
				
			}
			Console.WriteLine("Done!");
			Console.Clear();
		}
	}
}
