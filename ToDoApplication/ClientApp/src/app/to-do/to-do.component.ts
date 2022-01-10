import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import * as _ from 'lodash';

@Component({
  selector: 'app-to-do',
  templateUrl: './to-do.component.html',
  styleUrls: ['./to-do.component.css']
})
export class ToDoComponent implements OnInit {

  TodoList: any = [];
  ButtonTitle: string = 'Add Reminder';
  constructor() { }

  ngOnInit(): void {
  }

  form = new FormGroup({
    reminderText: new FormControl('', [Validators.required]),
    id: new FormControl(''),
  });

  get f() {
    return this.form.controls;
  }

  submit() {
    debugger;
    var formData = this.form.value;
    if (formData.id) {
      _.forEach(this.TodoList, (o: any) => {
        if (o.Id == formData.id) {
          o.ReminderText = formData.reminderText;
        }
      });
    }
    else {
      var postData = { "Id": this.TodoList.length + 1, "ReminderText": formData.reminderText, "IsDeleted": false, "SequenceNo": this.TodoList.length + 1 };
      this.TodoList.push(postData);
    }

    this.Reset();
    this.ReArrangeSequence();
  }

  EditToDo(todoData: any) {
    console.log(todoData);
    this.ButtonTitle = "Update Reminder";
    this.form.setValue({
      reminderText: todoData.ReminderText,
      id: todoData.Id
    });

  }

  DeleteToDo(todoData: any, index: any) {
    debugger;
    todoData.IsDeleted = true;
    todoData.SequenceNo = '';
    this.ReArrangeSequence();

  }

  ReArrangeSequence() {
    debugger;
    var NotDeleteList = _.filter(this.TodoList, function (o) {
      return o.IsDeleted == false;
    });

    if (NotDeleteList.length > 0) {
      _.forEach(NotDeleteList, (o: any, index: any) => {
        o.SequenceNo = index + 1;
      });
    }
    var DeleteList = _.orderBy(_.filter(this.TodoList, function (o) {
      return o.IsDeleted == true;
    }), 'DeletedSequenceNo');

    if (DeleteList.length > 0) {
      _.forEach(DeleteList, (o: any, index: any) => {
        o.DeletedSequenceNo = index + 1;
      });
    }

    this.TodoList = [];
    this.TodoList = _.concat(NotDeleteList, DeleteList);
  }
  Reset() {
    this.ButtonTitle = 'Add Reminder';
    this.form.reset();
  }
}
