using PatientClass;
using System.Collections.Generic;
using System;
using System.Collections;

namespace NivelAccesDate
{
    public interface IStocareData
    {
        void New_Patient(Patient patient);
        void NewListOfPatients(List<Patient> ListOfPatients);

        ArrayList GetPatients();

        Patient GetPatient(int idPatient, List<Patient> lst);

        Patient GetPatient(string nume);

        bool UpdatePacient(Patient PacientActualizat);

        List<Patient> GetPatient();
    }
}
