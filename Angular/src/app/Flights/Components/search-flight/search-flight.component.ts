import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Flight } from '../../Models/flight';
import { ApiService } from '../../Services/flights.service';

@Component({
  selector: 'app-search-flight',
  templateUrl: './search-flight.component.html',
  styleUrls: ['./search-flight.component.css']
})
export class SearchFlightComponent implements OnInit {
  flightList: Flight[] = [];

  constructor(private router: Router, private flightService: ApiService) { }

  flightData: Flight[] = [];

  ngOnInit(): void {

    this.flightService.getAllFlights().subscribe(
      res => { this.flightData = res; console.log(res) },
      error => {
        console.log(error)
      }
    );
  }
  flightdata: any;
  search(value1, value2) {
    this.flightdata = this.flightData.filter(obj => {
console.log(obj)
      return obj.Source == value1 && obj.Destination == value2
    })
  }

  onBook(id:number,sor:string,des:string)
  {
    // this.router.navigate(['booking/' + `${id}`]);
    this.router.navigate(['booking/' + `${id}/` + `${sor}/` + `${des}`]);
  }

}
