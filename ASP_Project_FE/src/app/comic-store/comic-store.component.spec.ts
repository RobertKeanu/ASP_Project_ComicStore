import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComicStoreComponent } from './comic-store.component';

describe('ComicStoreComponent', () => {
  let component: ComicStoreComponent;
  let fixture: ComponentFixture<ComicStoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComicStoreComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ComicStoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
