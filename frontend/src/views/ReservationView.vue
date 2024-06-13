<template>
  <div class="min-h-full">
    <BaseNavbar />
    <header class="bg-white shadow-sm">
      <div class="mx-auto max-w-7xl px-4 py-4 sm:px-6 lg:px-8">
        <h1 class="text-lg font-semibold leading-6 text-gray-900">Reserve area</h1>
      </div>
    </header>
    <main>
      <div class="mx-auto max-w-7xl py-6 sm:px-6 lg:px-8">
        <div class="container mx-auto p-4">
          <h1 class="text-2xl font-bold mb-4">Choose facility</h1>
          <div v-if="error" class="text-red-500">{{ error.message }}</div>
          <div v-else>
            <div class="grid grid-cols-1 md:grid-cols-3 gap-4">
              <router-link
                  v-for="facility in facilities"
                  :key="facility.id"
                  :to="{ name: 'FacilityAreas', params: { facilityId: facility.id } }"
                  class="bg-white rounded-lg shadow-lg p-6 block"
              >
                <div class="bg-gray-200 h-40 rounded-t-lg mb-4 flex items-center justify-center">
                  <span class="text-gray-500">Image Placeholder</span>
                </div>
                <div>
                  <h2 class="text-xl font-semibold mb-2">{{ facility.name }}</h2>
                  <p class="text-gray-700">
                    <span class="font-bold">Address:</span>
                    {{ facility.address.street }} {{ facility.address.buildingNo }}, {{ facility.address.city }}
                  </p>
                  <p class="text-gray-600">
                    <span class="font-bold">Capacity:</span>
                    {{ facility.capacity }}
                  </p>
                </div>
              </router-link>
            </div>
          </div>
        </div>
      </div>
    </main>
  </div>
</template>

<script setup>
import { onMounted } from 'vue';
import BaseNavbar from '../components/BaseNavbar.vue';
import { useFacilities } from '../composables/useFacilities';

const { facilities, error, fetchFacilities } = useFacilities();

onMounted(() => {
  fetchFacilities();
});
</script>
