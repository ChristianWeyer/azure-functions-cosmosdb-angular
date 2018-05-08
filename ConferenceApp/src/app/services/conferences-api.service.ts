import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ConferencesApiService {
  constructor(private _http: HttpClient) {
  }

  public listSessions() {
    return this._http.get(environment.baseApiUrl);
  }
}
