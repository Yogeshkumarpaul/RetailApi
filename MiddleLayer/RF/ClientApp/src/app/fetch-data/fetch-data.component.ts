import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public products: Products[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
    http.get<Products[]>(baseUrl + 'api/Products').subscribe(result => {
      this.products = result;
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

interface Products {
  ProductId: number;
  ProductName: string;
  ProductTypeId: number;
  Prate: number;
  MarginPer: number;
  MarginAmount: number;
  Srate: number;
  InitStock: number;
  MagUnitId: number;
  ColorId: number;
  ManufacturerId: number;
  SupplierId: number;
  SizeId: number;
  SuitableFor: string;
}
