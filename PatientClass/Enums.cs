using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientClass
{
    public enum DetineCard
    {
        DA = 1,
        NU = 2
    }

    public enum Genul
    {
        MASCULIN = 1,
        FEMININ = 2
    }

    public enum TipCetatenie
    {
        ROMANA = 1,
        GERMANA = 2,
        ENGLEZA = 3,
        FRANCEZA = 4
        
    }

    public enum ContinutPacient
    {
        NUME = 0,
        PRENUME = 1,
        SEX = 2,
        VARSTA = 3,
        CETATEAN = 4,
        DATANASTERE = 5,
        MOTIVINTERNARE = 6,
        CARD = 7,
        DATAINTERNARE = 8,
        SIMPTOME = 9
    }
}
