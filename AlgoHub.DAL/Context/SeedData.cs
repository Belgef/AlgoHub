using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AlgoHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GachiHelp.DAL.Context
{
    internal static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

        }
        private static string HashPassword(string password) => Convert.ToBase64String(SHA256.HashData(Encoding.Default.GetBytes(password)));
    }
}