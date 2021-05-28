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
        ID = 0,
        NUME = 1,
        PRENUME = 2,
        SEX = 3,
        VARSTA = 4,
        CETATEAN = 5,
        DATANASTERE = 6,
        MOTIVINTERNARE = 7,
        CARD = 8,
        DATAINTERNARE = 9,
        BOLI = 10
    }
}
