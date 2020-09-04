using System;
using System.ComponentModel;

namespace HarmelLaw.JusticeApp.Investigation
{
    // List from https://www.cps.gov.uk/sites/default/files/documents/publications/annex_1a_table_of_offences_scheme_c.pdf
    public enum CriminalOffence
    {
        [Description("Dangerous driving")]
        DANGEROUS_DRIVING,

        [Description("Endangering an aircraft")]
        ENDANGERING_AN_AIRCRAFT,
        
        [Description("False accounting")]
        FALSE_ACCOUNTING,
        
        [Description("Impersonating Customs officer")]
        IMPERSONATING_CUSTOMS_OFFICER,
        
        [Description("Keeping a disorderly house")]
        KEEPING_A_DISORDERLY_HOUSE,
        
        [Description("Corruption in public office")]
        CORRUPTION_IN_PUBLIC_OFFICE,
        
        [Description("Cutting away buoys etc")]
        CUTTING_AWAY_BUOYS_ETC,
        
        [Description("False evidence before European Court")]
        FALSE_EVIDENCE_BEFORE_EUROPEAN_COURT,
        
        [Description("Firing on Revenue vessel")]
        FIRING_ON_REVENUE_VESSEL,
        
        [Description("Fraudulent evasion of agricultural levy")]
        FRAUDULENT_EVASION_OF_AGRICULTURAL_LEVY,
        
        [Description("Obstructing engine or carriage on railway")]
        OBSTRUCTING_ENGINE_OR_CARRIAGE_ON_RAILWAY
    }
}