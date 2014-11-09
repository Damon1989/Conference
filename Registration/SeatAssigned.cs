﻿using System;
using ENode.Eventing;

namespace Registration.Events
{
    public class SeatAssigned : DomainEvent<Guid>
    {
        public int Position { get; private set; }
        public Guid SeatType { get; private set; }
        public RegistrantInfo Attendee { get; private set; }

        public SeatAssigned(Guid sourceId, int position, Guid seatType, RegistrantInfo attendee) : base(sourceId)
        {
            Position = position;
            SeatType = seatType;
            Attendee = attendee;
        }
    }
}
