﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorioGestionReservaHotel
{
    public class PrecargaHabitacion
    {

        public List<Habitación> PrecargaHabitaciones()
        {
            List<Habitación> precargaHabitaciones = new List<Habitación>();

            precargaHabitaciones.Add(new Habitación(101, "Simple", 2, 100));
            precargaHabitaciones.Add(new Habitación(102, "Doble", 4, 150));
            precargaHabitaciones.Add(new Habitación(103, "Suite", 6, 200));
            precargaHabitaciones.Add(new Habitación(104, "Simple", 2, 100));
            precargaHabitaciones.Add(new Habitación(105, "Doble", 4, 150));
            precargaHabitaciones.Add(new Habitación(106, "Suite", 6, 200));
            precargaHabitaciones.Add(new Habitación(107, "Simple", 2, 100));
            precargaHabitaciones.Add(new Habitación(108, "Doble", 4, 150));
            precargaHabitaciones.Add(new Habitación(109, "Suite", 6, 200));
            precargaHabitaciones.Add(new Habitación(110, "Simple", 2, 100));
            return precargaHabitaciones;
            
        }
    }
}