import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeadTrackComponent } from './lead-track.component';

describe('LeadTrackComponent', () => {
  let component: LeadTrackComponent;
  let fixture: ComponentFixture<LeadTrackComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LeadTrackComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LeadTrackComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
