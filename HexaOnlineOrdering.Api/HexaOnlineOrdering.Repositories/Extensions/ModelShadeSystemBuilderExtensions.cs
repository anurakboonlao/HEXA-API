using System;
using HexaOnlineOrdering.Repositories.DataModels;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories.Extensions
{    public static class ModelShadeSystemBuilderExtensions
	{
        public static void SeedShadeSystemData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblShadeSystem>().HasData(
                new TblShadeSystem()
                {
                    Id = 1,
                    Name = "VITA",
                    Order = 10,
                    ProductTypeId = 1
                },
                new TblShadeSystem()
                {
                    Id = 2,
                    Name = "IVOCLAR A-D shade",
                    Order = 20,
                    ProductTypeId = 1
                },
                new TblShadeSystem()
                {
                    Id = 3,
                    Name = "IVOCLAR CROMASCOP",
                    Order = 30,
                    ProductTypeId = 1
                },
                new TblShadeSystem()
                {
                    Id = 4,
                    Name = "YAMAHASHI",
                    Order = 40,
                    ProductTypeId = 2
                },
                new TblShadeSystem()
                {
                    Id = 5,
                    Name = "COSMO",
                    Order = 50,
                    ProductTypeId = 2
                },
                new TblShadeSystem()
                {
                    Id = 6,
                    Name = "IVOCLAR CROMASCOP",
                    Order = 60,
                    ProductTypeId = 2
                },
                new TblShadeSystem()
                {
                    Id = 7,
                    Name = "Majordent",
                    Order = 70,
                    ProductTypeId = 2
                },
                new TblShadeSystem()
                {
                    Id = 8,
                    Name = "YAMAHACHI MONOPLANE (Flat AC)",
                    Order = 80,
                    ProductTypeId = 2
                },
                new TblShadeSystem()
                {
                    Id = 9,
                    Name = "ORTHOLUX",
                    Order = 90,
                    ProductTypeId = 2
                },
                new TblShadeSystem()
                {
                    Id = 10,
                    Name = "IVOCLAR A-D shade",
                    Order = 100,
                    ProductTypeId = 2
                },
                new TblShadeSystem()
                {
                    Id = 11,
                    Name = "VITA",
                    Order = 110,
                    ProductTypeId = 2
                },
                new TblShadeSystem()
                {
                    Id = 12,
                    Name = "LIVERA",
                    Order = 120,
                    ProductTypeId = 2
                }
            );
        }

        public static void SeedShadeData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblShade>().HasData(
                new TblShade()
                {
                    Id = 1,
                    Name = "1M1",
                    Order = 10,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 2,
                    Name = "2L1.5",
                    Order = 20,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 3,
                    Name = "2M1",
                    Order = 30,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 4,
                    Name = "2M2",
                    Order = 40,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 5,
                    Name = "3L1.5",
                    Order = 50,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 6,
                    Name = "3L2.5",
                    Order = 60,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 7,
                    Name = "3M2",
                    Order = 70,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 8,
                    Name = "3R2.5",
                    Order = 80,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 9,
                    Name = "4L1.5",
                    Order = 90,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 10,
                    Name = "4M2",
                    Order = 100,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 11,
                    Name = "5M1",
                    Order = 110,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 12,
                    Name = "A1",
                    Order = 120,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 13,
                    Name = "A3",
                    Order = 130,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 14,
                    Name = "C3",
                    Order = 140,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 15,
                    Name = "D3",
                    Order = 150,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 16,
                    Name = "B1",
                    Order = 160,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 17,
                    Name = "B2",
                    Order = 170,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 18,
                    Name = "A2",
                    Order = 180,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 19,
                    Name = "C2/D4",
                    Order = 190,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 20,
                    Name = "B3",
                    Order = 200,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 21,
                    Name = "A3/D3",
                    Order = 210,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 22,
                    Name = "A3.5",
                    Order = 220,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 23,
                    Name = "A4",
                    Order = 230,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 24,
                    Name = "C4",
                    Order = 240,
                    ShadeSystemId = 1
                },
                new TblShade()
                {
                    Id = 25,
                    Name = "A1",
                    Order = 250,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 26,
                    Name = "A2",
                    Order = 260,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 27,
                    Name = "A3",
                    Order = 270,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 28,
                    Name = "A3.5",
                    Order = 280,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 29,
                    Name = "A4",
                    Order = 290,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 30,
                    Name = "B1",
                    Order = 300,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 31,
                    Name = "B2",
                    Order = 310,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 32,
                    Name = "B3",
                    Order = 320,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 33,
                    Name = "B3",
                    Order = 330,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 34,
                    Name = "B4",
                    Order = 340,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 35,
                    Name = "C1",
                    Order = 350,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 36,
                    Name = "C2",
                    Order = 360,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 37,
                    Name = "C3",
                    Order = 370,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 38,
                    Name = "C4",
                    Order = 380,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 39,
                    Name = "D2",
                    Order = 390,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 40,
                    Name = "D3",
                    Order = 400,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 41,
                    Name = "D4",
                    Order = 410,
                    ShadeSystemId = 2
                },
                new TblShade()
                {
                    Id = 42,
                    Name = "01",
                    Order = 420,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 43,
                    Name = "1A",
                    Order = 430,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 44,
                    Name = "2A",
                    Order = 440,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 45,
                    Name = "1C",
                    Order = 450,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 46,
                    Name = "2B",
                    Order = 460,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 47,
                    Name = "1D",
                    Order = 470,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 48,
                    Name = "1E",
                    Order = 480,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 49,
                    Name = "2C",
                    Order = 490,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 50,
                    Name = "3A",
                    Order = 500,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 51,
                    Name = "5B",
                    Order = 510,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 52,
                    Name = "2E",
                    Order = 520,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 53,
                    Name = "3E",
                    Order = 530,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 54,
                    Name = "4A",
                    Order = 540,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 55,
                    Name = "6B",
                    Order = 550,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 56,
                    Name = "4B",
                    Order = 560,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 57,
                    Name = "6C",
                    Order = 570,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 58,
                    Name = "6D",
                    Order = 580,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 59,
                    Name = "4C",
                    Order = 590,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 60,
                    Name = "3C",
                    Order = 600,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 61,
                    Name = "4D",
                    Order = 610,
                    ShadeSystemId = 3
                },
                new TblShade()
                {
                    Id = 62,
                    Name = "A1",
                    Order = 620,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 63,
                    Name = "A2",
                    Order = 630,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 64,
                    Name = "A3",
                    Order = 640,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 65,
                    Name = "A3.5",
                    Order = 650,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 66,
                    Name = "A4",
                    Order = 660,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 67,
                    Name = "B1",
                    Order = 670,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 68,
                    Name = "B2",
                    Order = 680,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 69,
                    Name = "B3",
                    Order = 690,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 70,
                    Name = "B4",
                    Order = 700,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 71,
                    Name = "C1",
                    Order = 710,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 72,
                    Name = "C2",
                    Order = 720,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 73,
                    Name = "C3",
                    Order = 730,
                    ShadeSystemId = 4
                },
                new TblShade()
                {
                    Id = 74,
                    Name = "A1",
                    Order = 740,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 75,
                    Name = "A2",
                    Order = 750,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 76,
                    Name = "A3",
                    Order = 760,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 77,
                    Name = "A3.5",
                    Order = 770,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 78,
                    Name = "A4",
                    Order = 780,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 79,
                    Name = "B2",
                    Order = 790,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 80,
                    Name = "B3",
                    Order = 800,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 81,
                    Name = "B4",
                    Order = 810,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 82,
                    Name = "C2",
                    Order = 820,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 83,
                    Name = "C3",
                    Order = 830,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 84,
                    Name = "C4",
                    Order = 840,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 85,
                    Name = "D2",
                    Order = 850,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 86,
                    Name = "D3",
                    Order = 860,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 87,
                    Name = "D4",
                    Order = 870,
                    ShadeSystemId = 5
                },
                new TblShade()
                {
                    Id = 88,
                    Name = "01",
                    Order = 880,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 89,
                    Name = "1A",
                    Order = 890,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 90,
                    Name = "2A",
                    Order = 900,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 91,
                    Name = "1C",
                    Order = 910,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 92,
                    Name = "2B",
                    Order = 920,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 93,
                    Name = "1D",
                    Order = 930,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 94,
                    Name = "1E",
                    Order = 940,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 95,
                    Name = "2C",
                    Order = 950,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 96,
                    Name = "3A",
                    Order = 960,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 97,
                    Name = "5B",
                    Order = 970,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 98,
                    Name = "2E",
                    Order = 98,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 99,
                    Name = "3E",
                    Order = 990,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 100,
                    Name = "4A",
                    Order = 1000,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 101,
                    Name = "6B",
                    Order = 1010,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 102,
                    Name = "4B",
                    Order = 1020,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 103,
                    Name = "6C",
                    Order = 1030,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 104,
                    Name = "6D",
                    Order = 1040,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 105,
                    Name = "4C",
                    Order = 1050,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 106,
                    Name = "3C",
                    Order = 1060,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 107,
                    Name = "4D",
                    Order = 1070,
                    ShadeSystemId = 6
                },
                new TblShade()
                {
                    Id = 108,
                    Name = "1D",
                    Order = 1080,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 109,
                    Name = "1F",
                    Order = 1090,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 110,
                    Name = "1R",
                    Order = 1100,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 111,
                    Name = "2C",
                    Order = 1110,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 112,
                    Name = "2L",
                    Order = 1120,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 113,
                    Name = "3D",
                    Order = 1130,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 114,
                    Name = "3F",
                    Order = 1140,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 115,
                    Name = "3R",
                    Order = 1150,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 116,
                    Name = "4C",
                    Order = 1160,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 117,
                    Name = "4F",
                    Order = 1170,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 118,
                    Name = "4L",
                    Order = 1180,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 119,
                    Name = "5C",
                    Order = 1190,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 120,
                    Name = "5D",
                    Order = 1200,
                    ShadeSystemId = 7
                },
                new TblShade()
                {
                    Id = 121,
                    Name = "A1",
                    Order = 1210,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 122,
                    Name = "A2",
                    Order = 1220,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 123,
                    Name = "A3",
                    Order = 1230,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 124,
                    Name = "A3.5",
                    Order = 1240,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 125,
                    Name = "A4",
                    Order = 1250,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 126,
                    Name = "B1",
                    Order = 1260,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 127,
                    Name = "B2",
                    Order = 1270,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 128,
                    Name = "B3",
                    Order = 1280,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 129,
                    Name = "B4",
                    Order = 1290,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 130,
                    Name = "C1",
                    Order = 1300,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 131,
                    Name = "C2",
                    Order = 1310,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 132,
                    Name = "C3",
                    Order = 1320,
                    ShadeSystemId = 8
                },
                new TblShade()
                {
                    Id = 133,
                    Name = "A1",
                    Order = 1330,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 134,
                    Name = "A2",
                    Order = 1340,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 135,
                    Name = "A3",
                    Order = 1350,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 136,
                    Name = "A3.5",
                    Order = 1360,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 137,
                    Name = "A4",
                    Order = 1370,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 138,
                    Name = "B2",
                    Order = 1380,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 139,
                    Name = "B4",
                    Order = 1390,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 140,
                    Name = "C1",
                    Order = 1400,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 141,
                    Name = "C2",
                    Order = 1410,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 142,
                    Name = "D4",
                    Order = 1420,
                    ShadeSystemId = 9
                },
                new TblShade()
                {
                    Id = 143,
                    Name = "A1",
                    Order = 1430,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 144,
                    Name = "A2",
                    Order = 1440,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 145,
                    Name = "A3",
                    Order = 1450,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 146,
                    Name = "A3.5",
                    Order = 1460,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 147,
                    Name = "A4",
                    Order = 1470,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 148,
                    Name = "B1",
                    Order = 1480,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 149,
                    Name = "B2",
                    Order = 1490,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 150,
                    Name = "B3",
                    Order = 1500,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 151,
                    Name = "B4",
                    Order = 1510,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 152,
                    Name = "C1",
                    Order = 1520,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 153,
                    Name = "C2",
                    Order = 1530,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 154,
                    Name = "C3",
                    Order = 1540,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 155,
                    Name = "C4",
                    Order = 1550,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 156,
                    Name = "D2",
                    Order = 1560,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 157,
                    Name = "D3",
                    Order = 1570,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 158,
                    Name = "D4",
                    Order = 1580,
                    ShadeSystemId = 10
                },
                new TblShade()
                {
                    Id = 159,
                    Name = "1M1",
                    Order = 1590,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 160,
                    Name = "2L1.5",
                    Order = 1600,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 161,
                    Name = "2M1",
                    Order = 1610,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 162,
                    Name = "2M2",
                    Order = 1620,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 163,
                    Name = "3L1.5",
                    Order = 1630,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 164,
                    Name = "3L2.5",
                    Order = 1640,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 165,
                    Name = "3M2",
                    Order = 1650,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 166,
                    Name = "3R2.5",
                    Order = 1660,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 167,
                    Name = "4L.15",
                    Order = 1670,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 168,
                    Name = "4M2",
                    Order = 1680,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 169,
                    Name = "5M1",
                    Order = 1690,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 170,
                    Name = "A1",
                    Order = 1700,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 171,
                    Name = "A3",
                    Order = 1710,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 172,
                    Name = "C3",
                    Order = 1720,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 173,
                    Name = "D3",
                    Order = 1730,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 174,
                    Name = "B1",
                    Order = 1740,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 175,
                    Name = "B2",
                    Order = 1750,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 176,
                    Name = "A2",
                    Order = 1760,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 177,
                    Name = "C2/D4",
                    Order = 1770,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 178,
                    Name = "B3",
                    Order = 1780,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 179,
                    Name = "A3/D3",
                    Order = 1790,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 180,
                    Name = "A3.5",
                    Order = 1800,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 181,
                    Name = "A4",
                    Order = 1810,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 182,
                    Name = "C4",
                    Order = 1820,
                    ShadeSystemId = 11
                },
                new TblShade()
                {
                    Id = 183,
                    Name = "A1",
                    Order = 1830,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 184,
                    Name = "A2",
                    Order = 1840,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 185,
                    Name = "A3",
                    Order = 1850,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 186,
                    Name = "A3.5",
                    Order = 1860,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 187,
                    Name = "A4",
                    Order = 1870,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 188,
                    Name = "B1",
                    Order = 1880,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 189,
                    Name = "B2",
                    Order = 1890,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 190,
                    Name = "B3",
                    Order = 1900,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 191,
                    Name = "B4",
                    Order = 1910,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 192,
                    Name = "C1",
                    Order = 1920,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 193,
                    Name = "C2",
                    Order = 1930,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 194,
                    Name = "C3",
                    Order = 1940,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 195,
                    Name = "C4",
                    Order = 1950,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 196,
                    Name = "D2",
                    Order = 1960,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 197,
                    Name = "D3",
                    Order = 1970,
                    ShadeSystemId = 12
                },
                new TblShade()
                {
                    Id = 198,
                    Name = "D4",
                    Order = 1980,
                    ShadeSystemId = 12
                }
            );
        }
    }
}

