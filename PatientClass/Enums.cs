﻿using System;
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
        ROMAN = 1,
        STRAIN = 2
    }

    public enum ContinutPacient
    {
        NUME = 1,
        PRENUME = 2,
        SEX = 3,
        VARSTA = 4,
        CETATEAN = 5,
        DATANASTERE = 6,
        MOTIVINTERNARE = 7,
        CARD = 8,
        DATAINTERNARE = 9
    }
}
