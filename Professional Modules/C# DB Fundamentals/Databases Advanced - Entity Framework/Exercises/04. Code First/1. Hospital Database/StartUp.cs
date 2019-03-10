﻿using System;
using Microsoft.EntityFrameworkCore.Design;
using P01_HospitalDatabase.Data;

namespace P01_HospitalDatabase 
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new HospitalContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
