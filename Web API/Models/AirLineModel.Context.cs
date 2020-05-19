﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airline_Reservation.web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AirLineDBEntities : DbContext
    {
        public AirLineDBEntities()
            : base("name=AirLineDBEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Cancellation> Cancellations { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
    
        public virtual int usp_AddFlight(Nullable<int> flightId, string flightName, string source, string destination, Nullable<System.DateTime> departureTime, Nullable<System.DateTime> arrivalTime, Nullable<int> baggageLimit, Nullable<int> availableSeats)
        {
            var flightIdParameter = flightId.HasValue ?
                new ObjectParameter("FlightId", flightId) :
                new ObjectParameter("FlightId", typeof(int));
    
            var flightNameParameter = flightName != null ?
                new ObjectParameter("FlightName", flightName) :
                new ObjectParameter("FlightName", typeof(string));
    
            var sourceParameter = source != null ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            var departureTimeParameter = departureTime.HasValue ?
                new ObjectParameter("DepartureTime", departureTime) :
                new ObjectParameter("DepartureTime", typeof(System.DateTime));
    
            var arrivalTimeParameter = arrivalTime.HasValue ?
                new ObjectParameter("ArrivalTime", arrivalTime) :
                new ObjectParameter("ArrivalTime", typeof(System.DateTime));
    
            var baggageLimitParameter = baggageLimit.HasValue ?
                new ObjectParameter("BaggageLimit", baggageLimit) :
                new ObjectParameter("BaggageLimit", typeof(int));
    
            var availableSeatsParameter = availableSeats.HasValue ?
                new ObjectParameter("AvailableSeats", availableSeats) :
                new ObjectParameter("AvailableSeats", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddFlight", flightIdParameter, flightNameParameter, sourceParameter, destinationParameter, departureTimeParameter, arrivalTimeParameter, baggageLimitParameter, availableSeatsParameter);
        }
    
        public virtual int usp_DeleteCancelledTicketById(Nullable<int> bookingId)
        {
            var bookingIdParameter = bookingId.HasValue ?
                new ObjectParameter("BookingId", bookingId) :
                new ObjectParameter("BookingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteCancelledTicketById", bookingIdParameter);
        }
    
        public virtual int usp_DeleteFlight(Nullable<int> flightId)
        {
            var flightIdParameter = flightId.HasValue ?
                new ObjectParameter("FlightId", flightId) :
                new ObjectParameter("FlightId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteFlight", flightIdParameter);
        }
    
        public virtual ObjectResult<usp_GetAllCancelledTickets_Result> usp_GetAllCancelledTickets()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetAllCancelledTickets_Result>("usp_GetAllCancelledTickets");
        }
    
        public virtual ObjectResult<usp_GetCancelledTicketById_Result> usp_GetCancelledTicketById(Nullable<int> bookingId)
        {
            var bookingIdParameter = bookingId.HasValue ?
                new ObjectParameter("BookingId", bookingId) :
                new ObjectParameter("BookingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetCancelledTicketById_Result>("usp_GetCancelledTicketById", bookingIdParameter);
        }
    
        public virtual int usp_UpdateFlight(Nullable<int> flightId, string flightName, string source, string destination, Nullable<System.DateTime> departureTime, Nullable<System.DateTime> arrivalTime, Nullable<int> baggageLimit, Nullable<int> availableSeats)
        {
            var flightIdParameter = flightId.HasValue ?
                new ObjectParameter("FlightId", flightId) :
                new ObjectParameter("FlightId", typeof(int));
    
            var flightNameParameter = flightName != null ?
                new ObjectParameter("FlightName", flightName) :
                new ObjectParameter("FlightName", typeof(string));
    
            var sourceParameter = source != null ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(string));
    
            var destinationParameter = destination != null ?
                new ObjectParameter("Destination", destination) :
                new ObjectParameter("Destination", typeof(string));
    
            var departureTimeParameter = departureTime.HasValue ?
                new ObjectParameter("DepartureTime", departureTime) :
                new ObjectParameter("DepartureTime", typeof(System.DateTime));
    
            var arrivalTimeParameter = arrivalTime.HasValue ?
                new ObjectParameter("ArrivalTime", arrivalTime) :
                new ObjectParameter("ArrivalTime", typeof(System.DateTime));
    
            var baggageLimitParameter = baggageLimit.HasValue ?
                new ObjectParameter("BaggageLimit", baggageLimit) :
                new ObjectParameter("BaggageLimit", typeof(int));
    
            var availableSeatsParameter = availableSeats.HasValue ?
                new ObjectParameter("AvailableSeats", availableSeats) :
                new ObjectParameter("AvailableSeats", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateFlight", flightIdParameter, flightNameParameter, sourceParameter, destinationParameter, departureTimeParameter, arrivalTimeParameter, baggageLimitParameter, availableSeatsParameter);
        }
    }
}
