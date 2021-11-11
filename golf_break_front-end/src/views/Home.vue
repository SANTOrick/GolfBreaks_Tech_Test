<template>
  <div v-if="!loading">
    <div class="home">
      <div v-for="adCat in response.product_lists" :key="adCat.title">
        <AdCategory :adCat="adCat"/>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue, { defineComponent } from "vue";
import store from "vuex";
import AdCategory from "../components/AdCategory.vue";
import golfBreaksApi from "../axios/golfBreaks.api";
import { AdResponse } from "../models/AdResponse";

export default defineComponent({
  components: { AdCategory },

  data(): {
    response: AdResponse | null;
    loading: boolean;
  } {
    return {
      response: null,
      loading: true,
    };
  },

  async created() {
    this.response = await golfBreaksApi.getAds();
    console.log(this.response);
    this.loading = false;
  },
});
</script>
