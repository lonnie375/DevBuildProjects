import { Component, OnInit, Input } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-social-posts',
  templateUrl: './social-posts.component.html',
  styleUrls: ['./social-posts.component.css']
})
export class SocialPostsComponent implements OnInit {

   newThought: boolean = false; 
    newPosts: boolean = false; 

 postLists: Post = {
    title: '',
    thought: ''
  }

  //This is our lists of posts 
  newPost: Post[] = []; 

  constructor() { }

  ngOnInit(): void {
  }

  addPosts(){
    let nextPost: Post ={
      title: this.postLists.title, 
      thought: this.postLists.thought
    }
    this.newPost.push(nextPost); 
    this.postLists.title = '', 
    this.postLists.thought = '', 
    this.newThought = false; 
  }

  showForm() {
    this.newThought = true; 
  }

  deleteItem(deletePost: Post){
    for(let i = 0; i < this.newPost.length; i++){
      if(this.newPost[i] == deletePost){
        this.newPost.splice(i,1);
        return; 
      }
    }
  }
}
