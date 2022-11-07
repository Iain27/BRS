using System;
using BRS_Prototype.Models;

namespace BRS_Prototype.ViewModels
{
    public class BloodRedSkiesViewModel
    {
        public IEnumerable<BloodRedSkiesPlane> BloodRedSkiesPlane { get; }
        public IEnumerable<Nation> Nation { get; }

        public BloodRedSkiesViewModel(IEnumerable<BloodRedSkiesPlane> bloodRedSkiesPlanes,  IEnumerable<Nation> nations )
        {
            BloodRedSkiesPlane = bloodRedSkiesPlanes;
            Nation = nations;
        }
    }
}

