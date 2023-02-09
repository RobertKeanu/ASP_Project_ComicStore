import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Comics } from '../interfaces/comics';
import { ApiService } from '../services/api/api.service';
import { ComicserviceService } from '../services/comicservice/comicservice.service';

@Component({
  selector: 'app-comics',
  templateUrl: './comics.component.html',
  styleUrls: ['./comics.component.css']

})
export class ComicsComponent implements OnInit {
  public comicChoice: Comics[] = [];
  public name: string = '';

  constructor(private readonly route: ActivatedRoute, private readonly comicservice: ComicserviceService, private apiService: ApiService) {

  }

  ngOnInit() {
  }
  GetAllComicsFromComicStores() {
    this.comicservice.GetAllComicsFromComicStores().subscribe((data: Comics[]) => {
      this.comicChoice = data;
    })
  }
}
