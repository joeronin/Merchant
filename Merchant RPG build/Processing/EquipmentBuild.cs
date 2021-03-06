﻿using System;
using System.Linq;
using MerchantRPG.Data;
using MerchantRPG.Simulation;

namespace Merchant_RPG_build.Processing
{
	public class EquipmentBuild
	{
		public readonly int Id;
		public readonly int[] Combination;
		public readonly Item[] Items;
		public Stats TotalStats;
		public double Score;

		public EquipmentBuild(int id, int[] combination)
		{
			this.Combination = combination;
			this.Id = id;
			this.Items = new Item[combination.Length];
		}
	}
}

