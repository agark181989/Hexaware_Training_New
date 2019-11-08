import { Directive, ElementRef, Renderer2, Input, OnInit, HostListener } from '@angular/core';

@Directive({
  selector: '[highlight]'
})
export class HighlightDirective implements OnInit{
  
  @Input("color") colorName:string="black";
  constructor(private el:ElementRef, private renderer:Renderer2) {
    this.renderer.setStyle(this.el.nativeElement, "color", this.colorName);
   }

   ngOnInit(){
    this.renderer.setStyle(this.el.nativeElement, "color", this.colorName);
   }

  @HostListener("mouseenter")
   applyColor(){
     this.renderer.setStyle(this.el.nativeElement, "background-color", "yellow");
   }

   @HostListener("mouseleave")
   removeColor(){
     this.renderer.removeStyle(this.el.nativeElement, "background-color");
   }

}
