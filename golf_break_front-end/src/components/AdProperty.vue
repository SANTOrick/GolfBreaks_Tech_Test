<template>
  <div class="Ad">
    <div class="main-wrapper">
      <div class="image-wrapper">
        <img :alt="ad.url" class="location-image" :src="ad.image.file.url" />
        <div class="star-wrapper">
          <div
            v-for="(n, i) in ad.data[0].venue_information.official_star_rating"
            :key="i"
            class="animation-wrapper"
          >
            <img class="star-image" :alt="i" src="../assets/star.png" />
          </div>
        </div>
      </div>
      <div class="description-wrapper">
        <div class="title-spacer">
          <span class="location-title">{{
            ad.parent_location.toUpperCase()
          }}</span>
          <div class="name-rating-wrapper">
            <span class="location-full-name">{{ ad.full_name }}</span>
          </div>
        </div>
      </div>
      <hr />
      <div class="offer-wrapper">
        <div class="offer-sub-wrapper">
          <span class="offer-duration">{{
            this.createOfferDescription()
          }}</span>
          <div class="price-wrapper">
            <span class="from-span">from</span>
            <div>
              <span class="price-span">£{{ ad.lead_product.price }}</span>
              <span>pp</span>
            </div>
          </div>
        </div>
        <img class="book-image" :alt="ad.url" src="../assets/book.png" />
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue, { defineComponent, PropType } from "vue";
import { Ad } from "../models/Ad";
import { AdCategory } from "../models/AdCategory";

export default defineComponent({
  props: { ad: Object as PropType<Ad> },
  data() {
    return {};
  },

  methods: {
    createOfferDescription() {
      let night = "night";
      let round = "round";

      if (this.ad!.lead_product.nights > 1) night = "nights";
      if (this.ad!.lead_product.rounds > 1) round = "rounds";

      return (
        this.ad!.lead_product.nights +
        " " +
        night +
        " & " +
        this.ad!.lead_product.rounds +
        " " +
        round
      );
    },
  },
});
</script>

<style scoped>
.location-image {
  height: 150px;
  width: 250px;
  padding-bottom: 15px;
  border-radius: 9px 9px 9px 45px;
}

.location-title {
  color: #9b9b9b;
  font-weight: bold;
  font-size: 12px;
  padding-bottom: 10px;
}

.from-span {
  font-size: 11px;
}

.price-wrapper {
  display: flex;
  flex-direction: column;
}

.image-wrapper {
  position: relative;
  transition: .3s;
}

.image-wrapper:hover {
  transform: scale(1.1); /* (150% zoom - Note: if the zoom is too large, it will go outside of the viewport) */
  z-index: 1;
}

.book-image {
  height: 60px;
}

.title-spacer {
  display: flex;
  flex-direction: column;
  text-align: initial;
}

.price-span {
  font-weight: bold;
  font-size: 32px;
}

.main-wrapper {
  display: flex;
  flex-direction: column;
}

.location-full-name {
  font-weight: bold;
  overflow: hidden;
  padding-right: 4px;
}

.offer-duration {
  font-size: 12px;
  color: gray;
}

.name-rating-wrapper {
  display: flex;
  justify-content: flex-start;
}

.star-wrapper {
  display: flex;
  flex-direction: row;
  align-items: flex-end;
  position: absolute;
  background-color: transparent;
  bottom: 20px;
  right: 10px;
}

.description-wrapper {
  display: flex;
  flex-direction: column;
}

.offer-wrapper {
  display: flex;
  justify-content: space-between;
}

.offer-sub-wrapper {
  display: flex;
  flex-direction: column;
  text-align: left;
}

.star-image {
  height: 15px;
}

.Ad {
  margin: 10px;
  width: 250px;
}

hr {
  border-color: #b5ada2;
  width: 100%;
  border-top-color: white;
}

.animation-wrapper {
  display: inline-block;
  height: 18px;
  width: 18px;
  bottom: 5px;
  position: relative;
  overflow: hidden;
}

.animation-wrapper img {
  position: absolute;
  top: 0px;
  left: 0;
  height: 100%;
  width: 100%;
  animation: hithere 1s linear;
  animation-fill-mode: both;
  -webkit-animation-name: bounce-in-right;
  -webkit-animation-duration: 0.2s;
}

.star-wrapper div:nth-child(1) img {
  animation-delay: 0.1s;
}
.star-wrapper div:nth-child(2) img {
  animation-delay: 0.2s;
}
.star-wrapper div:nth-child(3) img {
  animation-delay: 0.3s;
}
.star-wrapper div:nth-child(4) img {
  animation-delay: 0.4s;
}

@keyframes bounce-in-right {
  0% {
    opacity: 0;
    transform: translateX(-30px);
  }
  20% {
    opacity: 1;
    transform: translateX(2000);
  }
}
</style>
