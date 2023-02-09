import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ApiService } from '../api/api.service';
import { Comics } from '../../interfaces/comics';


@Injectable({
  providedIn: 'root'
})
export class ComicserviceService {
  private baseUrl = '/comics';

  constructor(private apiService: ApiService) { }

  GetAllComicsFromComicStores(): Observable<Comics[]> {
    return this.apiService.get(`${this.baseUrl}/GetAllComicsFromComicStores`);
  }
}
