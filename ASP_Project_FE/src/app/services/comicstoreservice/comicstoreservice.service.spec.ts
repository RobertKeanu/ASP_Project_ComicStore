import { TestBed } from '@angular/core/testing';

import { ComicstoreserviceService } from './comicstoreservice.service';

describe('ComicstoreserviceService', () => {
  let service: ComicstoreserviceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ComicstoreserviceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
