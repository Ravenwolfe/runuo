using System;
using Server;

namespace Server.Items
{
	public class Bleach : PigmentsOfTokuno
	{
		public override int LabelNumber { get { return 1075375; } } // Bleach

		[Constructable]
		public Bleach() : base( PigmentType.None )
		{
			LootType = LootType.Blessed;
		}

		public Bleach( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
