import { ComponentFixture, TestBed } from '@angular/core/testing';

import { City1 } from './city1';

describe('City1', () => {
  let component: City1;
  let fixture: ComponentFixture<City1>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [City1]
    })
    .compileComponents();

    fixture = TestBed.createComponent(City1);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
