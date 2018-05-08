import { TestBed, inject } from '@angular/core/testing';

import { ConferencesApiService } from './conferences-api.service';

describe('ConferencesApiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ConferencesApiService]
    });
  });

  it('should be created', inject([ConferencesApiService], (service: ConferencesApiService) => {
    expect(service).toBeTruthy();
  }));
});
