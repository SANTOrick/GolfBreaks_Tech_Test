<template>
  <div class="stabilizer">
    <span class="title">{{ adCat.title }}</span>
    <div class="test">
      <div v-for="ad in adCat.items" :key="ad.url">
        <AdProperty :ad="ad" />
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue, { defineComponent, PropType } from "vue";
import { AdCategory } from "../models/AdCategory";
import AdProperty from "./AdProperty.vue";

export default defineComponent({
  props: { adCat: Object as PropType<AdCategory> },

  components: {
    AdProperty,
  },

  data() {
    return {};
  },
});
</script>

<style scoped>
.test {
  display: flex;
}

.stabilizer {
  display: flex;
  flex-direction: column;
  margin: 70px;
  padding-left: 300px;
  padding-right: 300px;
}

.title {
  text-align: initial;
  font-size: 30px;
  margin-bottom: 30px;
}
</style>
