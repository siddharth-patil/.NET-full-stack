import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestMath } from './test-math';

describe('TestMath', () => {
  let component: TestMath;
  let fixture: ComponentFixture<TestMath>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TestMath]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TestMath);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
