import { Component, OnInit } from '@angular/core';
import { User } from '../_models/user';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  users: User[];
  values: any;

  constructor(private userService: UserService, private alertify: AlertifyService, private http: HttpClient) { }

  ngOnInit() {
    this.loadUsers();
    // this.getValues();
  }

  loadUsers() {
    this.userService.getUsers().subscribe((users: User[]) => {
      this.users = users;
      console.log(this.users);
    }, error => {
      this.alertify.error(error);
    });
  }

  getValues() {
    this.http.get('http://localhost:5000/api/values/').subscribe(response => {
      this.values = response;
      console.log(response);
    }, error => {
      console.log(error);
    });
  }
}
