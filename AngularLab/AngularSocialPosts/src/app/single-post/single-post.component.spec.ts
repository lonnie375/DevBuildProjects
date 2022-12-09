import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingplePostComponent } from './single-post.component';

describe('SingplePostComponent', () => {
  let component: SingplePostComponent;
  let fixture: ComponentFixture<SingplePostComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingplePostComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SingplePostComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
