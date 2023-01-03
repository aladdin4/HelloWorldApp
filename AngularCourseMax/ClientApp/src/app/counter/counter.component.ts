import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export abstract class CounterComponent {
    
  public currentCount = 0;
    public x = 0;
    public abstract incrementCounter(): string;
    
}

//the singleton pattern in TS we can only have one instance of x now!
export class X{
    private static instance: X;

    private constructor() {

    }

    //we can only call this method, and only her can call the constuctor based on the 
    //current static field (instance) has a value or not
    static getInstance() {
        if (X.instance) {
            return X.instance;
        }
        else {
            X.instance = new X();
            return X.instance;
        }
    }
    
}


export interface testInterface {
    a: string;
    b: number;
    c(d: string): string;
}

export class myClass extends CounterComponent implements testInterface {
    //all those members are auto generated due to extending and implementing
    public incrementCounter(): string {
        throw new Error('Method not implemented.');
    }
    a: string;
    b: number;
    c(d: string): string {
        throw new Error('Method not implemented.');
    }
   
}

let user1: testInterface;
user1 = {};

function Add(x: number, y: number) {
    return x + y;

}
let m = Add(5, 6.2);
let p: {name: "A"} = { name: 'A' };
console.log("working !");

let myArr = [5, 6 , 10, 'val'];

myArr.push("hi");
