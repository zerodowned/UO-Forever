using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a bear corpse" )]
	[TypeAlias( "Server.Mobiles.Bear" )]
	public class BlackBear : BaseCreature
	{
		public override string DefaultName{ get{ return "a black bear"; } }

		[Constructable]
		public BlackBear() : base( AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Body = 211;
			BaseSoundID = 0xA3;

			SetStr( 76, 100 );
			SetDex( 56, 75 );
			SetInt( 11, 14 );

			SetHits( 46, 60 );
			SetMana( 0 );

			SetDamage( 4, 10 );

			

			
			
			

			SetSkill( SkillName.MagicResist, 20.1, 40.0 );
			SetSkill( SkillName.Tactics, 40.1, 60.0 );
			SetSkill( SkillName.Wrestling, 40.1, 60.0 );

			Fame = 450;
			Karma = 0;

			VirtualArmor = 24;

			Tamable = true;
			ControlSlots = 1;
			MinTameSkill = 35.1;
		}

		public override int Meat{ get{ return 1; } }
		public override int Hides{ get{ return 12; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Fish | FoodType.Meat | FoodType.FruitsAndVeggies; } }
		public override PackInstinct PackInstinct{ get{ return PackInstinct.Bear; } }

		public BlackBear( Serial serial ) : base( serial )
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}