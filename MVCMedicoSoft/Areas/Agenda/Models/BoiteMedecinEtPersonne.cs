﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMedicoSoft.Areas.Agenda.Models
{
    public class BoiteMedecinEtPersonne
    {

        List<Personne> _lstPers;
        List<Medecin> _lstMed;

        public List<Personne> LstMed
        {
            get { return _lstMed; }
            set { _lstMed = value; }
        }

        public List<Personne> LstPers
        {
            get { return; }
            set { }
        }
    }
}