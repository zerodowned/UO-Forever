using System;

namespace Server.Engines.Harvest
{
	public class HarvestBank
	{
		private int m_Current;
		private int m_Maximum;
		private DateTime m_NextRespawn;
        public DateTime NextRespawn
        {
            get { return m_NextRespawn; }
            set { m_NextRespawn = value; }
        }
		private HarvestVein m_Vein, m_DefaultVein;

		public HarvestDefinition Definition { get; private set; }

		public int Current
		{
			get
			{
				CheckRespawn();
				return m_Current;
			}
		}

		public HarvestVein Vein
		{
			get
			{
				CheckRespawn();
				return m_Vein;
			}
			set
			{
				m_Vein = value;
			}
		}

		public HarvestVein DefaultVein
		{
			get
			{
				CheckRespawn();
				return m_DefaultVein;
			}
		}

		public void CheckRespawn()
		{
			if ( m_Current == m_Maximum || m_NextRespawn > DateTime.UtcNow )
				return;

			m_Current = m_Maximum;

			if ( Definition.RandomizeVeins )
			{
				m_DefaultVein = Definition.GetVeinFrom(Utility.RandomDouble() );
			}

			m_Vein = m_DefaultVein;
		}

		public void Consume( int amount, Mobile from )
		{
			CheckRespawn();

			if ( m_Current == m_Maximum )
			{
				double min = Definition.MinRespawn.TotalMinutes;
				double max = Definition.MaxRespawn.TotalMinutes;
				double rnd = Utility.RandomDouble();

				m_Current = m_Maximum - amount;

				double minutes = min + (rnd * (max - min));
				if ( Definition.RaceBonus && from.Race == Race.Elf )	//def.RaceBonus = Core.ML
					minutes *= .75;	//25% off the time.

				m_NextRespawn = DateTime.UtcNow + TimeSpan.FromMinutes( minutes );
			}
			else
			{
				m_Current -= amount;
			}

			if ( m_Current < 0 )
				m_Current = 0;
		}

		public HarvestBank( HarvestDefinition def, HarvestVein defaultVein )
		{
			m_Maximum = Utility.RandomMinMax( def.MinTotal, def.MaxTotal );
			m_Current = m_Maximum;
			m_DefaultVein = defaultVein;
			m_Vein = m_DefaultVein;

			Definition = def;
		}
	}
}