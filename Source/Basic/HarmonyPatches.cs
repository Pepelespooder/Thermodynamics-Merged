using System;
using System.Reflection;
using HarmonyLib;
using Verse;
using System.Linq;
using System.Reflection.Emit;
using RimWorld;

namespace DHotMeals
{
	public class HarmonyPatches : Verse.Mod
	{
		public HarmonyPatches(ModContentPack content) : base(content)
		{
			var harmony = new Harmony("io.github.dametri.hotmeals");
			var assembly = Assembly.GetExecutingAssembly();
			harmony.PatchAll(assembly);
		}


	}
}
