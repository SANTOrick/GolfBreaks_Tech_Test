<template>
  <div class="Ad">
    <div class="main-wrapper">
      <img :alt="ad.url" class="location-image" :src="ad.image.file.url" />
      <div class="description-wrapper">
        <div class="title-spacer">
          <span class="location-title">{{
            ad.parent_location.toUpperCase()
          }}</span>
          <div class="name-rating-wrapper">
            <span class="location-full-name">{{ ad.full_name }}</span>
            <div class="star-wrapper">
              <div
                v-for="(n, i) in ad.data[0].venue_information
                  .official_star_rating"
                :key="i"
              >
                <img class="star-image" :alt="i" src="../assets/star.png" />
              </div>
            </div>
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
        <img class="book-image" :alt="ad.url" src="../assets/book_online.png" />
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
  border-radius: 9px;
  padding-bottom: 15px;
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
  border-top: gray;
  width: 100%;
}
</style>
