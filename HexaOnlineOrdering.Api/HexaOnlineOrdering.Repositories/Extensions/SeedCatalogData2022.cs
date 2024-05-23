using System;
using HexaOnlineOrdering.Repositories.DataModels;
using Microsoft.EntityFrameworkCore;

namespace HexaOnlineOrdering.Repositories.Extensions
{
    public static class SeedCatalogData2022
    {
        public static void SeedDataCatalog2022(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCatalog>(entity =>
            {
                entity.HasData(
                #region plate 
                     new TblCatalog()
                     {
                         Id = 99,
                         Name = "Red 901",
                         LogoPath = "/Catalog/22_901.jpg",
                         CatalogGroupId = 1,
                         Disabled = false,
                         OrderNumber = 1
                     },
                    new TblCatalog()
                    {
                        Id = 100,
                        Name = "Yellow 902",
                        LogoPath = "/Catalog/22_902.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 2
                    },
                    new TblCatalog()
                    {
                        Id = 101,
                        Name = "Blue 903",
                        LogoPath = "/Catalog/22_903.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 3
                    },
                    new TblCatalog()
                    {
                        Id = 102,
                        Name = "Green 904",
                        LogoPath = "/Catalog/22_904.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 4
                    },
                    new TblCatalog()
                    {
                        Id = 103,
                        Name = "Blue 905",
                        LogoPath = "/Catalog/22_905.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 5
                    },
                    new TblCatalog()
                    {
                        Id = 104,
                        Name = "Blue 906",
                        LogoPath = "/Catalog/22_906.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 6
                    },
                    new TblCatalog()
                    {
                        Id = 105,
                        Name = "Purple 907",
                        LogoPath = "/Catalog/22_907.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 7
                    },
                    new TblCatalog()
                    {
                        Id = 106,
                        Name = "Turquoise 908",
                        LogoPath = "/Catalog/22_908.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 8
                    },
                    new TblCatalog()
                    {
                        Id = 107,
                        Name = "White 909 ขาวทึบ",
                        LogoPath = "/Catalog/22_909.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 9
                    },
                    new TblCatalog()
                    {
                        Id = 108,
                        Name = "Violet 910",
                        LogoPath = "/Catalog/22_910.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 10
                    },
                    new TblCatalog()
                    {
                        Id = 109,
                        Name = "Black 912",
                        LogoPath = "/Catalog/22_912.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 11
                    },
                    new TblCatalog()
                    {
                        Id = 110,
                        Name = "Magenta 913",
                        LogoPath = "/Catalog/22_913.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 12
                    },
                    new TblCatalog()
                    {
                        Id = 111,
                        Name = "Neon Yellow 914",
                        LogoPath = "/Catalog/22_914.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 13
                    },
                    new TblCatalog()
                    {
                        Id = 112,
                        Name = "Neon Green 915",
                        LogoPath = "/Catalog/22_915.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 14
                    },
                    new TblCatalog()
                    {
                        Id = 113,
                        Name = "Neon Orange 916",
                        LogoPath = "/Catalog/22_916.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 15
                    },
                    new TblCatalog()
                    {
                        Id = 114,
                        Name = "Neon Pink 917",
                        LogoPath = "/Catalog/22_917.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 16
                    },
                    new TblCatalog()
                    {
                        Id = 115,
                        Name = "Pink Opaque 921",
                        LogoPath = "/Catalog/22_921.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 17
                    },
                    new TblCatalog()
                    {
                        Id = 116,
                        Name = "Clear 922 ขาวใส",
                        LogoPath = "/Catalog/22_922.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 18
                    },
                    new TblCatalog()
                    {
                        Id = 117,
                        Name = "Pink Tone 923",
                        LogoPath = "/Catalog/22_923.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 19
                    },
                    new TblCatalog()
                    {
                        Id = 118,
                        Name = "Red A901",
                        LogoPath = "/Catalog/22_A901.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 20
                    },
                    new TblCatalog()
                    {
                        Id = 119,
                        Name = "Yellow A902",
                        LogoPath = "/Catalog/22_A902.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 21
                    },
                    new TblCatalog()
                    {
                        Id = 120,
                        Name = "Blue A903",
                        LogoPath = "/Catalog/22_A903.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 22
                    },
                    new TblCatalog()
                    {
                        Id = 121,
                        Name = "Purple A907",
                        LogoPath = "/Catalog/22_A907.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 23
                    },
                    new TblCatalog()
                    {
                        Id = 122,
                        Name = "Megenta A913",
                        LogoPath = "/Catalog/22_A913.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 24
                    },
                    new TblCatalog()
                    {
                        Id = 123,
                        Name = "Pink Tone A923",
                        LogoPath = "/Catalog/22_A923.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 25
                    },
                    new TblCatalog()
                    {
                        Id = 124,
                        Name = "HC 01",
                        LogoPath = "/Catalog/HC01.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 26
                    },
                    new TblCatalog()
                    {
                        Id = 125,
                        Name = "HC 02",
                        LogoPath = "/Catalog/HC02.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 27
                    },
                    new TblCatalog()
                    {
                        Id = 126,
                        Name = "HC 03",
                        LogoPath = "/Catalog/HC03.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 28
                    },
                    new TblCatalog()
                    {
                        Id = 127,
                        Name = "HC 07",
                        LogoPath = "/Catalog/HC07.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 29
                    },
                    new TblCatalog()
                    {
                        Id = 128,
                        Name = "HC 08",
                        LogoPath = "/Catalog/HC08.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 30
                    },
                    new TblCatalog()
                    {
                        Id = 129,
                        Name = "HC 09",
                        LogoPath = "/Catalog/HC09.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 31
                    },
                    new TblCatalog()
                    {
                        Id = 130,
                        Name = "HC 13",
                        LogoPath = "/Catalog/HC13.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 32
                    },
                    new TblCatalog()
                    {
                        Id = 131,
                        Name = "HC 14",
                        LogoPath = "/Catalog/HC14.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 33
                    },
                    new TblCatalog()
                    {
                        Id = 132,
                        Name = "HC 15",
                        LogoPath = "/Catalog/HC15.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 34
                    },
                    new TblCatalog()
                    {
                        Id = 133,
                        Name = "HC 19",
                        LogoPath = "/Catalog/HC19.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 35
                    },
                    new TblCatalog()
                    {
                        Id = 134,
                        Name = "HC 20",
                        LogoPath = "/Catalog/HC20.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 36
                    },
                    new TblCatalog()
                    {
                        Id = 135,
                        Name = "HC 21",
                        LogoPath = "/Catalog/HC21.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 37
                    },
                    new TblCatalog()
                    {
                        Id = 136,
                        Name = "HC 04",
                        LogoPath = "/Catalog/HC04.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 38
                    },
                    new TblCatalog()
                    {
                        Id = 137,
                        Name = "HC 05",
                        LogoPath = "/Catalog/HC05.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 39
                    },
                    new TblCatalog()
                    {
                        Id = 138,
                        Name = "HC 06",
                        LogoPath = "/Catalog/HC06.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 40
                    },
                    new TblCatalog()
                    {
                        Id = 139,
                        Name = "HC 10",
                        LogoPath = "/Catalog/HC10.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 41
                    },
                    new TblCatalog()
                    {
                        Id = 140,
                        Name = "HC 11",
                        LogoPath = "/Catalog/HC11.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 42
                    },
                    new TblCatalog()
                    {
                        Id = 141,
                        Name = "HC 12",
                        LogoPath = "/Catalog/HC12.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 43
                    },
                    new TblCatalog()
                    {
                        Id = 142,
                        Name = "HC 16",
                        LogoPath = "/Catalog/HC16.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 44
                    },
                    new TblCatalog()
                    {
                        Id = 143,
                        Name = "HC 17",
                        LogoPath = "/Catalog/HC17.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 45
                    },
                    new TblCatalog()
                    {
                        Id = 144,
                        Name = "HC 18",
                        LogoPath = "/Catalog/HC18.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 46
                    },
                    new TblCatalog()
                    {
                        Id = 145,
                        Name = "HC 22",
                        LogoPath = "/Catalog/HC22.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 47
                    },
                    new TblCatalog()
                    {
                        Id = 146,
                        Name = "HC 23",
                        LogoPath = "/Catalog/HC23.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 48
                    },
                    new TblCatalog()
                    {
                        Id = 147,
                        Name = "HC 24",
                        LogoPath = "/Catalog/HC24.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 49
                    },
                    new TblCatalog()
                    {
                        Id = 148,
                        Name = "HC 25",
                        LogoPath = "/Catalog/HC25.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 50
                    },
                    new TblCatalog()
                    {
                        Id = 149,
                        Name = "HC 26",
                        LogoPath = "/Catalog/HC26.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 51
                    },
                    new TblCatalog()
                    {
                        Id = 150,
                        Name = "HC 27",
                        LogoPath = "/Catalog/HC27.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 52
                    },
                    new TblCatalog()
                    {
                        Id = 151,
                        Name = "HC 28",
                        LogoPath = "/Catalog/HC28.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 53
                    },
                    new TblCatalog()
                    {
                        Id = 152,
                        Name = "HC 29",
                        LogoPath = "/Catalog/HC29.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 54
                    },
                    new TblCatalog()
                    {
                        Id = 153,
                        Name = "HC 30",
                        LogoPath = "/Catalog/HC30.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 55
                    },
                    new TblCatalog()
                    {
                        Id = 154,
                        Name = "HC 31",
                        LogoPath = "/Catalog/HC31.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 56
                    },
                    new TblCatalog()
                    {
                        Id = 155,
                        Name = "HC 32",
                        LogoPath = "/Catalog/HC32.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 57
                    },
                    new TblCatalog()
                    {
                        Id = 156,
                        Name = "HC 33",
                        LogoPath = "/Catalog/HC33.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 58
                    },
                    new TblCatalog()
                    {
                        Id = 157,
                        Name = "HC 34",
                        LogoPath = "/Catalog/HC34.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 59
                    },
                    new TblCatalog()
                    {
                        Id = 158,
                        Name = "HC 35",
                        LogoPath = "/Catalog/HC35.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 60
                    },
                    new TblCatalog()
                    {
                        Id = 159,
                        Name = "HC 36",
                        LogoPath = "/Catalog/HC36.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 61
                    },
                    new TblCatalog()
                    {
                        Id = 160,
                        Name = "HC 37",
                        LogoPath = "/Catalog/HC37.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 62
                    },
                    new TblCatalog()
                    {
                        Id = 161,
                        Name = "HC 38",
                        LogoPath = "/Catalog/HC38.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 63
                    },
                    new TblCatalog()
                    {
                        Id = 162,
                        Name = "HC 39",
                        LogoPath = "/Catalog/HC39.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 64
                    },
                    new TblCatalog()
                    {
                        Id = 163,
                        Name = "HC 40",
                        LogoPath = "/Catalog/HC40.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 65
                    },
                    new TblCatalog()
                    {
                        Id = 164,
                        Name = "HC 41",
                        LogoPath = "/Catalog/HC41.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 66
                    },
                    new TblCatalog()
                    {
                        Id = 165,
                        Name = "HC 42",
                        LogoPath = "/Catalog/HC42.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 67
                    },
                    new TblCatalog()
                    {
                        Id = 166,
                        Name = "HC 43",
                        LogoPath = "/Catalog/HC43.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 68
                    },
                    new TblCatalog()
                    {
                        Id = 167,
                        Name = "HC 44",
                        LogoPath = "/Catalog/HC44.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 69
                    },
                    new TblCatalog()
                    {
                        Id = 168,
                        Name = "HC 45",
                        LogoPath = "/Catalog/HC45.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 70
                    },
                    new TblCatalog()
                    {
                        Id = 169,
                        Name = "HC 46",
                        LogoPath = "/Catalog/HC46.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 71
                    },
                    new TblCatalog()
                    {
                        Id = 170,
                        Name = "HC 47",
                        LogoPath = "/Catalog/HC47.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 72
                    },
                    new TblCatalog()
                    {
                        Id = 171,
                        Name = "HC 48",
                        LogoPath = "/Catalog/HC48.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 73
                    },
                    new TblCatalog()
                    {
                        Id = 172,
                        Name = "HC 49",
                        LogoPath = "/Catalog/HC49.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 74
                    },
                    new TblCatalog()
                    {
                        Id = 173,
                        Name = "HC 50",
                        LogoPath = "/Catalog/HC50.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 75
                    },
                    new TblCatalog()
                    {
                        Id = 174,
                        Name = "HC 51",
                        LogoPath = "/Catalog/HC51.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 76
                    },
                    new TblCatalog()
                    {
                        Id = 175,
                        Name = "HC 52",
                        LogoPath = "/Catalog/HC52.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 77
                    },
                    new TblCatalog()
                    {
                        Id = 176,
                        Name = "HC 53",
                        LogoPath = "/Catalog/HC53.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 78
                    },
                    new TblCatalog()
                    {
                        Id = 177,
                        Name = "HC 54",
                        LogoPath = "/Catalog/HC54.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 79
                    },
                    new TblCatalog()
                    {
                        Id = 178,
                        Name = "HC 55",
                        LogoPath = "/Catalog/HC55.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 80
                    },
                    new TblCatalog()
                    {
                        Id = 179,
                        Name = "HC 56",
                        LogoPath = "/Catalog/HC56.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 81
                    },
                    new TblCatalog()
                    {
                        Id = 180,
                        Name = "HC 57",
                        LogoPath = "/Catalog/HC57.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 82
                    },
                    new TblCatalog()
                    {
                        Id = 181,
                        Name = "HC 58",
                        LogoPath = "/Catalog/HC58.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 83
                    },
                    new TblCatalog()
                    {
                        Id = 182,
                        Name = "HC 59",
                        LogoPath = "/Catalog/HC59.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 84
                    },
                    new TblCatalog()
                    {
                        Id = 183,
                        Name = "HC 60",
                        LogoPath = "/Catalog/HC60.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 85
                    },
                    new TblCatalog()
                    {
                        Id = 184,
                        Name = "HC 61",
                        LogoPath = "/Catalog/HC61.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 86
                    },
                    new TblCatalog()
                    {
                        Id = 185,
                        Name = "HC 62",
                        LogoPath = "/Catalog/HC62.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 87
                    },
                    #endregion

                    #region Glitter
                    new TblCatalog()
                    {
                        Id = 186,
                        Name = "Glitter Green",
                        LogoPath = "/Catalog/glitter-green.jpg",
                        CatalogGroupId = 2,
                        Disabled = false,
                        OrderNumber = 88
                    },
                    new TblCatalog()
                    {
                        Id = 187,
                        Name = "Glitter Silver",
                        LogoPath = "/Catalog/glitter-silver.jpg",
                        CatalogGroupId = 2,
                        Disabled = false,
                        OrderNumber = 89
                    },
                    new TblCatalog()
                    {
                        Id = 188,
                        Name = "Glitter Red",
                        LogoPath = "/Catalog/glitter-red.jpg",
                        CatalogGroupId = 2,
                        Disabled = false,
                        OrderNumber = 90
                    },
                    new TblCatalog()
                    {
                        Id = 189,
                        Name = "Glitter Blue",
                        LogoPath = "/Catalog/glitter-blue.jpg",
                        CatalogGroupId = 2,
                        Disabled = false,
                        OrderNumber = 91
                    },
                    new TblCatalog()
                    {
                        Id = 190,
                        Name = "Glitter Colorful",
                        LogoPath = "/Catalog/glitter-colorful.jpg",
                        CatalogGroupId = 2,
                        Disabled = false,
                        OrderNumber = 92
                    },
                    new TblCatalog()
                    {
                        Id = 191,
                        Name = "Glitter Gold",
                        LogoPath = "/Catalog/glitter-gold.jpg",
                        CatalogGroupId = 2,
                        Disabled = false,
                        OrderNumber = 93
                    },
                    new TblCatalog()
                    {
                        Id = 192,
                        Name = "Glitter Purple",
                        LogoPath = "/Catalog/glitter-purple.jpg",
                        CatalogGroupId = 2,
                        Disabled = false,
                        OrderNumber = 94
                    },
                    new TblCatalog()
                    {
                        Id = 193,
                        Name = "Glitter Pink",
                        LogoPath = "/Catalog/glitter-pink.jpg",
                        CatalogGroupId = 2,
                        Disabled = false,
                        OrderNumber = 95
                    },

                    #endregion

                    #region plate 
                    new TblCatalog()
                    {
                        Id = 194,
                        Name = "HC 63",
                        LogoPath = "/Catalog/HC63.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 96
                    },
                    new TblCatalog()
                    {
                        Id = 195,
                        Name = "HC 64",
                        LogoPath = "/Catalog/HC64.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 97
                    },
                    new TblCatalog()
                    {
                        Id = 196,
                        Name = "HC 65",
                        LogoPath = "/Catalog/HC65.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 98
                    },
                    new TblCatalog()
                    {
                        Id = 197,
                        Name = "HC 66",
                        LogoPath = "/Catalog/HC66.jpg",
                        CatalogGroupId = 1,
                        Disabled = false,
                        OrderNumber = 99
                    }
                    #endregion
                 );

            });
        }
    }
}
