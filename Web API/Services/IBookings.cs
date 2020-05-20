﻿//***************************************************************************************
//Developer: <Ashita Gaur>
//Create Date: <17th May,2020>
//Last Updated Date: <20th May,2020>
//Description:To perform Business logic and accordingly return response to Bookings.
//Task:CRUD with opreation with flight
//***************************************************************************************


using Airline_Reservation.web.Models;
using System.Collections.Generic;

namespace Airline_Reservation.web.Services
{
    /// <summary>
    ///  Interface that implements Booking Service
    /// </summary>
    public interface IBookings
    {
        List<Booking> GetAllBookings();
    }    
}
