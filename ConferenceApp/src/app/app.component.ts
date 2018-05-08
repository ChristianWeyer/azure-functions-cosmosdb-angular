import {Component, OnInit} from '@angular/core';
import {ConferencesApiService} from './services/conferences-api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';
  sessions: any;

  constructor(private _conferencesApi: ConferencesApiService) {
  }

  ngOnInit(): void {
    this._conferencesApi.listSessions()
      .subscribe(result => {
        this.sessions = result;
      });
  }
}
