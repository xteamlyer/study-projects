import { Component } from '@angular/core';
import { SwiperOptions } from 'swiper';

@Component({
  selector: 'app-swiper',
  template: `
    <swiper [config]="swiperConfig">
      <ng-template swiperSlide>Slide 1</ng-template>
      <ng-template swiperSlide>Slide 2</ng-template>
      <ng-template swiperSlide>Slide 3</ng-template>
      <ng-template swiperSlide>Slide 4</ng-template>
    </swiper>
  `,
})
export class SwiperComponent {
  swiperConfig: SwiperOptions = {
    slidesPerView: 2,
    spaceBetween: 10,
    // Другие опции Swiper.js по желанию
  };
}
