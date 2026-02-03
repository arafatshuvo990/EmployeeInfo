import { TestBed } from '@angular/core/testing';

import { EmployeeInfo } from './employee-info';

describe('EmployeeInfo', () => {
  let service: EmployeeInfo;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EmployeeInfo);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
