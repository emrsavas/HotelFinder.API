﻿using HotelFinder.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    interface IhotelRepostory
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelById(int id);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);

    }
}
