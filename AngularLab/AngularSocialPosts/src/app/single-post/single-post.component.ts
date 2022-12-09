import { DomElementSchemaRegistry } from '@angular/compiler';
import { Component, OnInit, Input, Output, EventEmitter} from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-single-post',
  templateUrl: './single-post.component.html',
  styleUrls: ['./single-post.component.css']
})
export class SingplePostComponent implements OnInit {

  //Input binding on Post!
  @Input() singlePost: Post = {
    title: '',
    thought: ''
  }

  editPost = false; 

  changeTitle = ''; 
  changeThought = ''; 

  @Output() delete: EventEmitter<Post> = new EventEmitter<Post>();

  constructor() { }

  ngOnInit(): void {
  }

  edit(){
    this.editPost = true; 
    this.changeTitle = this.singlePost.title; 
    this.changeThought = this.singlePost.thought; 
  }

  savePost(){
    this.editPost = false; 
    this.singlePost.title = this.changeTitle; 
    this.singlePost.thought = this.changeThought; 
  }

  cancel() {
    this.editPost = false; 
  }

  deleted() {
    this.delete.emit(this.singlePost);
  }
}
