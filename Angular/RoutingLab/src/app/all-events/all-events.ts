import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-all-events',
  imports: [RouterLink, CommonModule],
  templateUrl: './all-events.html',
  styleUrl: './all-events.css'
})
export class AllEvents {

  allEvents:any[]=[
    {
      eventName:'Event 1',
      eventDate: '2025-08-15T10:00:00',
      to:'2025-08-15T14:00:00',
      address:'xyz, Pune',
      contactNo:'9922717103'
    },
    {
      eventName:'Event 1',
      eventDate: '2025-08-15T10:00:00',
      to:'2025-08-15T14:00:00',
      address:'xyz, Pune',
      contactNo:'9922717103'
    },
    {
      eventName:'Event 1',
      eventDate: '2025-08-15T10:00:00',
      to:'2025-08-15T14:00:00',
      address:'xyz, Pune',
      contactNo:'9922717103'
    }
  ];

}
