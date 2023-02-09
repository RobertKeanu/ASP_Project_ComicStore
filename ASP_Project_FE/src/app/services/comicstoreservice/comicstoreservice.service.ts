import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ComicStore } from '../../interfaces/ComicStore';
import { ApiService } from '../api/api.service';

@Injectable({
  providedIn: 'root'
})
export class ComicstoreserviceService {


  private baseUrl = '/comic-store';

  constructor(private apiService: ApiService) { }

  GetComicStore(): Observable<ComicStore[]> {
    return this.apiService.get(`${this.baseUrl}/GetComicStore`);
  }
}
