import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewFeeDetailsComponent } from './view-fee-details.component';

describe('ViewfeeDetailsComponent', () => {
  let component: ViewFeeDetailsComponent;
  let fixture: ComponentFixture<ViewFeeDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewFeeDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewFeeDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
