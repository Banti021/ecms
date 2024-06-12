<template>
  <div class="min-h-full">
    <BaseNavbar />
    <header class="bg-white shadow-sm">
      <div v-if="facility && facility.name" class="mx-auto max-w-7xl px-4 py-4 sm:px-6 lg:px-8">
        <h1 class="text-lg font-semibold leading-6 text-gray-900">{{ facility.name }} - Areas</h1>
      </div>
      <div v-else class="mx-auto max-w-7xl px-4 py-4 sm:px-6 lg:px-8">
        <h1 class="text-lg font-semibold leading-6 text-gray-900">Loading...</h1>
      </div>
    </header>
    <main>
      <div class="mx-auto max-w-7xl py-6 sm:px-6 lg:px-8">
        <div class="container mx-auto p-4">
          <div>
            <div class="grid grid-cols-1 md:grid-cols-3 gap-4">
              <div v-for="area in areasForFacility" :key="area.id" class="bg-white rounded-lg shadow-lg p-6">
                <div class="bg-gray-200 h-40 rounded-t-lg mb-4 flex items-center justify-center">
                  <span class="text-gray-500">Image Placeholder</span>
                </div>
                <div>
                  <h2 class="text-xl font-semibold mb-2">{{ area.name }}</h2>
                  <p class="text-gray-700">{{ area.description }}</p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </main>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue';
import { useRoute } from 'vue-router';
import BaseNavbar from '../components/BaseNavbar.vue';
import { useAreas } from '../composables/useAreas';
import { useFacilities } from '../composables/useFacilities';

const route = useRoute();
const facility = ref({});
const areasError = ref(null);

const { areasForFacility, fetchAreasForFacility } = useAreas();
const {facility: fetchedFacility, fetchFacility} = useFacilities();

const fetchFacilityDetails = async () => {
  try {
    await fetchFacility(route.params.id);
    facility.value = fetchedFacility.value;
    console.log('Facility Details', facility.value);
    await fetchAreasForFacility(route.params.id);
  } catch (err) {
    areasError.value = err;
  }
};

onMounted(fetchFacilityDetails);
</script>
