// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class HalloweenHellPitAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new HalloweenHellPitAddonDeed();}}
		[ Constructable ]
		public HalloweenHellPitAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 2278 );
			ac.Hue = 1257;
			AddComponent( ac, -1, 4, 0 );

			ac = new AddonComponent( 4963 );
			ac.Hue = 1255;
			AddComponent( ac, -1, 3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -1, 3, 2 );

			ac = new AddonComponent( 14089 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, -1, 2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -1, 2, 2 );

			ac = new AddonComponent( 2274 );
			ac.Hue = 1257;
			AddComponent( ac, -1, 1, 12 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -1, 1, 2 );

			ac = new AddonComponent( 2274 );
			ac.Hue = 1256;
			AddComponent( ac, -1, 0, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -1, 0, 2 );

			ac = new AddonComponent( 2272 );
			ac.Hue = 1257;
			AddComponent( ac, -1, -1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -1, -1, 2 );

			ac = new AddonComponent( 2275 );
			ac.Hue = 1257;
			AddComponent( ac, -1, -2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -1, -2, 2 );

			ac = new AddonComponent( 2274 );
			ac.Hue = 1257;
			AddComponent( ac, -1, -3, 2 );

			ac = new AddonComponent( 13549 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, -1, -3, 18 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -1, -3, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -1, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -1, -4, 2 );

			ac = new AddonComponent( 2272 );
			ac.Hue = 1257;
			AddComponent( ac, -2, 4, 2 );

			ac = new AddonComponent( 13372 );
			ac.Hue = 1257;
			AddComponent( ac, -2, 4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -2, 3, 2 );

			ac = new AddonComponent( 2274 );
			ac.Hue = 1257;
			AddComponent( ac, -2, 2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -2, 2, 2 );

			ac = new AddonComponent( 2272 );
			ac.Hue = 1257;
			AddComponent( ac, -2, 1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -2, 1, 2 );

			ac = new AddonComponent( 2272 );
			ac.Hue = 1257;
			AddComponent( ac, -2, 0, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -2, 0, 2 );

			ac = new AddonComponent( 2278 );
			ac.Hue = 1257;
			AddComponent( ac, -2, -1, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -2, -2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -2, -2, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -2, -3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -2, -3, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -2, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -2, -4, 2 );

			ac = new AddonComponent( 2273 );
			ac.Hue = 1257;
			AddComponent( ac, -3, 4, 2 );

			ac = new AddonComponent( 13371 );
			ac.Hue = 1258;
			AddComponent( ac, -3, 4, 2 );

			ac = new AddonComponent( 13597 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, -3, 3, 5 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -3, 3, 2 );

			ac = new AddonComponent( 2275 );
			ac.Hue = 1257;
			AddComponent( ac, -3, 2, 2 );

			ac = new AddonComponent( 13579 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, -3, 2, 7 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -3, 2, 2 );

			ac = new AddonComponent( 2278 );
			ac.Hue = 1257;
			AddComponent( ac, -3, 1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, -3, 1, 2 );

			ac = new AddonComponent( 13579 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, -3, 1, 12 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -3, 1, 2 );

			ac = new AddonComponent( 2275 );
			ac.Hue = 1257;
			AddComponent( ac, -3, 0, 2 );

			ac = new AddonComponent( 13579 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, -3, 0, 17 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -3, 0, 2 );

			ac = new AddonComponent( 2274 );
			ac.Hue = 1257;
			AddComponent( ac, -3, -1, 2 );

			ac = new AddonComponent( 13579 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, -3, -1, 22 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -3, -1, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -3, -2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -3, -2, 2 );

			ac = new AddonComponent( 2317 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, -3, -3, 19 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -3, -3, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -3, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, -3, -4, 2 );

			ac = new AddonComponent( 2273 );
			ac.Hue = 1256;
			AddComponent( ac, -4, 4, 2 );

			ac = new AddonComponent( 2273 );
			ac.Hue = 1257;
			AddComponent( ac, -4, 3, 2 );

			ac = new AddonComponent( 2273 );
			ac.Hue = 1257;
			AddComponent( ac, -4, 2, 2 );

			ac = new AddonComponent( 2274 );
			ac.Hue = 1255;
			AddComponent( ac, -4, 1, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -4, -1, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -4, -2, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -4, -3, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, -4, -4, 2 );

			ac = new AddonComponent( 14742 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -2, 2, 12 );

			ac = new AddonComponent( 2281 );
			ac.Hue = 1257;
			AddComponent( ac, 4, 3, 2 );

			ac = new AddonComponent( 2277 );
			ac.Hue = 1257;
			AddComponent( ac, 4, 2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 4, 2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 4, 1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 4, 0, 2 );

			ac = new AddonComponent( 2279 );
			ac.Hue = 1257;
			AddComponent( ac, 4, -1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 4, -1, 2 );

			ac = new AddonComponent( 2272 );
			ac.Hue = 1257;
			AddComponent( ac, 4, -2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 4, -2, 2 );

			ac = new AddonComponent( 4963 );
			ac.Hue = 1256;
			AddComponent( ac, 4, -3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 4, -3, 2 );

			ac = new AddonComponent( 2278 );
			ac.Hue = 1256;
			AddComponent( ac, 4, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 4, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 3, 3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 3, 2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 3, 1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 3, 0, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 3, -1, 2 );

			ac = new AddonComponent( 4970 );
			ac.Hue = 1256;
			AddComponent( ac, 3, -2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 3, -2, 2 );

			ac = new AddonComponent( 2273 );
			ac.Hue = 1257;
			AddComponent( ac, 3, -3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 3, -3, 2 );

			ac = new AddonComponent( 2275 );
			ac.Hue = 1257;
			AddComponent( ac, 3, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 3, -4, 2 );

			ac = new AddonComponent( 2276 );
			ac.Hue = 1257;
			AddComponent( ac, 2, 3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 2, 3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 2, 2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 2, 1, 2 );

			ac = new AddonComponent( 14089 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 2, 0, 2 );

			ac = new AddonComponent( 2323 );
			AddComponent( ac, 2, 0, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 2, 0, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 2, -1, 2 );

			ac = new AddonComponent( 4963 );
			ac.Hue = 1255;
			AddComponent( ac, 2, -2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 2, -2, 2 );

			ac = new AddonComponent( 13567 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, 2, -3, 5 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 2, -3, 2 );

			ac = new AddonComponent( 2274 );
			ac.Hue = 1256;
			AddComponent( ac, 2, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 2, -4, 2 );

			ac = new AddonComponent( 2276 );
			ac.Hue = 1257;
			AddComponent( ac, 1, 4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 1, 3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 1, 2, 2 );

			ac = new AddonComponent( 8452 );
			ac.Hue = 1260;
			AddComponent( ac, 1, 1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 1, 1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 1, 0, 2 );

			ac = new AddonComponent( 2276 );
			ac.Hue = 1257;
			AddComponent( ac, 1, -1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 1, -1, 2 );

			ac = new AddonComponent( 2275 );
			ac.Hue = 1257;
			AddComponent( ac, 1, -2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 1, -2, 2 );

			ac = new AddonComponent( 2275 );
			ac.Hue = 1257;
			AddComponent( ac, 1, -3, 2 );

			ac = new AddonComponent( 13549 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, 1, -3, 6 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 1, -3, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1255;
			AddComponent( ac, 1, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 1, -4, 2 );

			ac = new AddonComponent( 4967 );
			ac.Hue = 1258;
			AddComponent( ac, 0, 4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 0, 3, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 0, 2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 0, 1, 2 );

			ac = new AddonComponent( 4967 );
			ac.Hue = 1258;
			AddComponent( ac, 0, 0, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 0, 0, 2 );

			ac = new AddonComponent( 2278 );
			ac.Hue = 1256;
			AddComponent( ac, 0, -1, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 0, -1, 2 );

			ac = new AddonComponent( 2280 );
			ac.Hue = 1256;
			AddComponent( ac, 0, -2, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 0, -2, 2 );

			ac = new AddonComponent( 13549 );
			ac.Hue = 33;
			ac.Name = "blood";
			AddComponent( ac, 0, -3, 12 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1257;
			AddComponent( ac, 0, -3, 2 );

			ac = new AddonComponent( 2274 );
			ac.Hue = 1255;
			AddComponent( ac, 0, -4, 2 );

			ac = new AddonComponent( 1339 );
			ac.Hue = 1260;
			AddComponent( ac, 0, -4, 2 );

			ac = new AddonComponent( 4655 );
			AddComponent( ac, 3, 0, 2 );

			ac = new AddonComponent( 4650 );
			AddComponent( ac, 2, 2, 2 );

			ac = new AddonComponent( 3786 );
			AddComponent( ac, 4, 0, 2 );

			ac = new AddonComponent( 3792 );
			AddComponent( ac, 0, 2, 2 );

			ac = new AddonComponent( 14732 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 2, -1, 2 );


		}
		public HalloweenHellPitAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class HalloweenHellPitAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new HalloweenHellPitAddon();}}
		[Constructable]
		public HalloweenHellPitAddonDeed(){Name = "HalloweenHellPit";}
		public HalloweenHellPitAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}